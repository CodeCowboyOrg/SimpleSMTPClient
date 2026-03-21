using System.Text.Json;

namespace SimpleSmtpClient;

/// <summary>
/// Application settings that are persisted between sessions.
/// </summary>
public class AppSettings
{
    private static readonly string SettingsDirectory = Path.Combine(
        Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
        "SimpleSmtpClient");

    private static readonly string SettingsFilePath = Path.Combine(SettingsDirectory, "settings.json");

    // SMTP Server Settings
    public string SmtpServer { get; set; } = string.Empty;
    public int Port { get; set; } = 587;
    public bool UseAuthentication { get; set; }
    public string Username { get; set; } = string.Empty;
    // Note: Password is not saved for security reasons
    public bool UseTls { get; set; }
    public int TlsVersionIndex { get; set; }

    // Email Settings
    public string EmailFrom { get; set; } = string.Empty;
    public string EmailTo { get; set; } = string.Empty;

    // Connection Settings
    public int ConnectionTimeoutSeconds { get; set; } = 30;

    // Logging Settings
    public bool EnableLogging { get; set; } = true;

    /// <summary>
    /// Loads settings from the settings file.
    /// Returns default settings if the file doesn't exist or is invalid.
    /// </summary>
    public static AppSettings Load()
    {
        try
        {
            if (File.Exists(SettingsFilePath))
            {
                var json = File.ReadAllText(SettingsFilePath);
                var settings = JsonSerializer.Deserialize<AppSettings>(json);
                return settings ?? new AppSettings();
            }
        }
        catch (Exception ex)
        {
            Logger.Log($"Failed to load settings: {ex.Message}", LogLevel.Warning);
        }

        return new AppSettings();
    }

    /// <summary>
    /// Saves the current settings to the settings file.
    /// </summary>
    public void Save()
    {
        try
        {
            // Ensure directory exists
            if (!Directory.Exists(SettingsDirectory))
            {
                Directory.CreateDirectory(SettingsDirectory);
            }

            var options = new JsonSerializerOptions
            {
                WriteIndented = true
            };

            var json = JsonSerializer.Serialize(this, options);
            File.WriteAllText(SettingsFilePath, json);

            Logger.Log("Settings saved successfully.", LogLevel.Info);
        }
        catch (Exception ex)
        {
            Logger.Log($"Failed to save settings: {ex.Message}", LogLevel.Error);
        }
    }

    /// <summary>
    /// Gets the path to the settings directory.
    /// </summary>
    public static string GetSettingsDirectory() => SettingsDirectory;
}
