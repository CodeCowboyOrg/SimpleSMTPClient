using System.Text.RegularExpressions;
using MailKit.Net.Smtp;
using MailKit.Security;
using MimeKit;

namespace SimpleSmtpClient;

public partial class MainForm : Form
{
    // Compiled regex for better performance (generated at compile time)
    [GeneratedRegex(@"^[^@\s]+@[^@\s]+\.[^@\s]+$", RegexOptions.IgnoreCase)]
    private static partial Regex EmailValidationRegex();

    private AppSettings _settings = null!;
    private CancellationTokenSource? _cancellationTokenSource;

    public MainForm()
    {
        InitializeComponent();
    }

    private void MainForm_Load(object sender, EventArgs e)
    {
        // Load settings
        _settings = AppSettings.Load();

        // Initialize logger
        Logger.IsEnabled = _settings.EnableLogging;
        Logger.Log("Application started.", LogLevel.Info);

        // Cleanup old logs (keep 30 days)
        Logger.CleanupOldLogs(30);

        // Apply loaded settings to form controls
        LoadSettingsToForm();

        // Initialize control states
        UpdateCredentialFieldsState();
        UpdateTlsVersionDropdownState();
    }

    private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
    {
        // Save settings before closing
        SaveSettingsFromForm();
        Logger.Log("Application closing.", LogLevel.Info);
    }

    private void LoadSettingsToForm()
    {
        guiServerName.Text = _settings.SmtpServer;
        guiPort.Text = _settings.Port.ToString();
        guiUseCredentials.Checked = _settings.UseAuthentication;
        guiUser.Text = _settings.Username;
        guiUseSsl.Checked = _settings.UseTls;
        cmbSSLVersion.SelectedIndex = _settings.TlsVersionIndex >= 0 && _settings.TlsVersionIndex < cmbSSLVersion.Items.Count
            ? _settings.TlsVersionIndex
            : 0;
        guiEmailFrom.Text = _settings.EmailFrom;
        guiEmailTo.Text = _settings.EmailTo;
        numTimeout.Value = Math.Clamp(_settings.ConnectionTimeoutSeconds, 5, 300);
        chkEnableLogging.Checked = _settings.EnableLogging;

        Logger.Log("Settings loaded to form.", LogLevel.Debug);
    }

    private void SaveSettingsFromForm()
    {
        _settings.SmtpServer = guiServerName.Text.Trim();

        if (int.TryParse(guiPort.Text.Trim(), out var port))
        {
            _settings.Port = port;
        }

        _settings.UseAuthentication = guiUseCredentials.Checked;
        _settings.Username = guiUser.Text.Trim();
        // Password is intentionally NOT saved for security
        _settings.UseTls = guiUseSsl.Checked;
        _settings.TlsVersionIndex = cmbSSLVersion.SelectedIndex;
        _settings.EmailFrom = guiEmailFrom.Text.Trim();
        _settings.EmailTo = guiEmailTo.Text.Trim();
        _settings.ConnectionTimeoutSeconds = (int)numTimeout.Value;
        _settings.EnableLogging = chkEnableLogging.Checked;

        _settings.Save();
    }

    private void guiUseCredentials_CheckedChanged(object sender, EventArgs e)
    {
        UpdateCredentialFieldsState();
    }

    private void guiUseSsl_CheckedChanged(object sender, EventArgs e)
    {
        UpdateTlsVersionDropdownState();
    }

    private void chkEnableLogging_CheckedChanged(object sender, EventArgs e)
    {
        Logger.IsEnabled = chkEnableLogging.Checked;
        Logger.Log($"Logging {(chkEnableLogging.Checked ? "enabled" : "disabled")}.", LogLevel.Info);
    }

    private void btnViewLog_Click(object sender, EventArgs e)
    {
        using var logViewer = new LogViewerForm();
        logViewer.ShowDialog(this);
    }

    private void btnOpenLogFolder_Click(object sender, EventArgs e)
    {
        Logger.OpenLogDirectory();
    }

    private void UpdateCredentialFieldsState()
    {
        var useCredentials = guiUseCredentials.Checked;
        guiUser.ReadOnly = !useCredentials;
        guiPassword.ReadOnly = !useCredentials;

        // Clear fields when disabling credentials
        if (!useCredentials)
        {
            guiUser.Text = string.Empty;
            guiPassword.Text = string.Empty;
        }
    }

    private void UpdateTlsVersionDropdownState()
    {
        cmbSSLVersion.Enabled = guiUseSsl.Checked;
        lblSSLVersion.Enabled = guiUseSsl.Checked;
    }

    private async void guiSendMail_Click(object sender, EventArgs e)
    {
        // Validate inputs before sending
        if (!ValidateInputs())
        {
            return;
        }

        var host = guiServerName.Text.Trim();
        var port = int.Parse(guiPort.Text.Trim());
        var fromEmail = guiEmailFrom.Text.Trim();
        var toEmail = guiEmailTo.Text.Trim();
        var useTls = guiUseSsl.Checked;

        // Log the attempt
        Logger.LogEmailAttempt(host, port, fromEmail, toEmail, useTls);

        // Create cancellation token with timeout
        var timeoutSeconds = (int)numTimeout.Value;
        _cancellationTokenSource = new CancellationTokenSource(TimeSpan.FromSeconds(timeoutSeconds));

        try
        {
            // Disable the button and show cancel option
            guiSendMail.Enabled = false;
            btnCancel.Visible = true;
            btnCancel.Enabled = true;
            guiSendMail.Text = "Sending...";

            using var client = new SmtpClient();

            // Determine SSL/TLS options based on user selection
            var socketOptions = GetSecureSocketOptions();

            // Connect to the server with timeout
            Logger.LogConnectionAttempt(host, port);
            await client.ConnectAsync(host, port, socketOptions, _cancellationTokenSource.Token);
            Logger.LogConnectionSuccess(host, port);

            // Authenticate if credentials are provided
            if (guiUseCredentials.Checked && !string.IsNullOrWhiteSpace(guiUser.Text))
            {
                Logger.LogAuthenticationAttempt(guiUser.Text);
                await client.AuthenticateAsync(guiUser.Text, guiPassword.Text, _cancellationTokenSource.Token);
                Logger.LogAuthenticationSuccess(guiUser.Text);
            }

            // Create and send the message
            var message = CreateMailMessage();
            await client.SendAsync(message, _cancellationTokenSource.Token);

            // Disconnect
            await client.DisconnectAsync(true, _cancellationTokenSource.Token);

            Logger.LogEmailSuccess(host, toEmail);
            MessageBox.Show("Email Sent.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Save settings after successful send
            SaveSettingsFromForm();
        }
        catch (OperationCanceledException)
        {
            if (_cancellationTokenSource?.IsCancellationRequested == true)
            {
                var message = btnCancel.Enabled ? "Connection timed out." : "Operation cancelled by user.";
                Logger.LogEmailFailure(host, toEmail, message);
                MessageBox.Show(message, "Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        catch (Exception ex)
        {
            Logger.LogEmailFailure(host, toEmail, ex.Message);
            MessageBox.Show($"Error sending email: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        finally
        {
            // Re-enable the button and hide cancel
            guiSendMail.Enabled = true;
            guiSendMail.Text = "Send Mail";
            btnCancel.Visible = false;
            btnCancel.Enabled = false;

            _cancellationTokenSource?.Dispose();
            _cancellationTokenSource = null;
        }
    }

    private void btnCancel_Click(object sender, EventArgs e)
    {
        btnCancel.Enabled = false;
        _cancellationTokenSource?.Cancel();
        Logger.Log("Send operation cancelled by user.", LogLevel.Info);
    }

    private SecureSocketOptions GetSecureSocketOptions()
    {
        if (!guiUseSsl.Checked)
        {
            return SecureSocketOptions.None;
        }

        // MailKit handles TLS negotiation automatically
        // For STARTTLS (most common), use Auto which will negotiate the best available protocol
        return cmbSSLVersion.SelectedIndex is 0 or -1
            ? SecureSocketOptions.Auto
            : SecureSocketOptions.StartTls;
    }

    private bool ValidateInputs()
    {
        // Validate server name
        if (string.IsNullOrWhiteSpace(guiServerName.Text))
        {
            ShowValidationError("Please enter the SMTP server name.", guiServerName);
            return false;
        }

        // Validate port
        if (string.IsNullOrWhiteSpace(guiPort.Text))
        {
            ShowValidationError("Please enter the SMTP port number.", guiPort);
            return false;
        }

        if (!int.TryParse(guiPort.Text.Trim(), out var port) || port is < 1 or > 65535)
        {
            ShowValidationError("Please enter a valid port number (1-65535).", guiPort);
            return false;
        }

        // Validate credentials if authentication is enabled
        if (guiUseCredentials.Checked && string.IsNullOrWhiteSpace(guiUser.Text))
        {
            ShowValidationError("Please enter a username for authentication.", guiUser);
            return false;
        }

        // Validate email addresses
        if (string.IsNullOrWhiteSpace(guiEmailFrom.Text))
        {
            ShowValidationError("Please enter a sender email address.", guiEmailFrom);
            return false;
        }

        if (!IsValidEmail(guiEmailFrom.Text.Trim()))
        {
            ShowValidationError("Please enter a valid sender email address.", guiEmailFrom);
            return false;
        }

        if (string.IsNullOrWhiteSpace(guiEmailTo.Text))
        {
            ShowValidationError("Please enter a recipient email address.", guiEmailTo);
            return false;
        }

        if (!IsValidEmail(guiEmailTo.Text.Trim()))
        {
            ShowValidationError("Please enter a valid recipient email address.", guiEmailTo);
            return false;
        }

        return true;
    }

    private static bool IsValidEmail(string email) => EmailValidationRegex().IsMatch(email);

    private void ShowValidationError(string message, Control control)
    {
        Logger.Log($"Validation error: {message}", LogLevel.Warning);
        MessageBox.Show(message, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        control.Focus();
    }

    private MimeMessage CreateMailMessage()
    {
        var message = new MimeMessage();
        message.From.Add(new MailboxAddress(string.Empty, guiEmailFrom.Text.Trim()));
        message.To.Add(new MailboxAddress(string.Empty, guiEmailTo.Text.Trim()));
        message.Subject = guiEmailSubject.Text;
        message.Body = new TextPart("plain")
        {
            Text = guiEmailBody.Text
        };
        return message;
    }
}
