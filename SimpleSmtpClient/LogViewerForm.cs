namespace SimpleSmtpClient;

public partial class LogViewerForm : Form
{
    public LogViewerForm()
    {
        InitializeComponent();
    }

    private void LogViewerForm_Load(object sender, EventArgs e)
    {
        RefreshLog();
    }

    private void btnRefresh_Click(object sender, EventArgs e)
    {
        RefreshLog();
    }

    private void btnClose_Click(object sender, EventArgs e)
    {
        Close();
    }

    private void btnOpenFolder_Click(object sender, EventArgs e)
    {
        Logger.OpenLogDirectory();
    }

    private void RefreshLog()
    {
        txtLog.Text = Logger.ReadTodaysLog();
        txtLog.SelectionStart = txtLog.Text.Length;
        txtLog.ScrollToCaret();
    }
}
