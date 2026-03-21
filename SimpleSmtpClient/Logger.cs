using System.Collections.Concurrent;
using System.Text;

namespace SimpleSmtpClient;

/// <summary>
/// Log level for categorizing log messages.
/// </summary>
public enum LogLevel
{
    Debug,
    Info,
    Warning,
    Error
}

/// <summary>
/// Simple file-based logger for the application.
/// </summary>
public static class Logger
{
    private static readonly string LogDirectory = Path.Combine(
        Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
        "SimpleSmtpClient",
        "Logs");

    private static readonly object LockObject = new();
    private static bool _isEnabled = true;
    private static readonly ConcurrentQueue<string> RecentLogs = new();
    private const int MaxRecentLogs = 1000;

    /// <summary>
    /// Gets or sets whether logging is enabled.
    /// </summary>
    public static bool IsEnabled
    {
        get => _isEnabled;
        set => _isEnabled = value;
    }

    /// <summary>
    /// Gets the current log file path.
    /// </summary>
    public static string CurrentLogFilePath => GetLogFilePath(DateTime.Now);

    /// <summary>
    /// Gets the log directory path.
    /// </summary>
    public static string LogDirectoryPath => LogDirectory;

    private static string GetLogFilePath(DateTime date)
    {
        return Path.Combine(LogDirectory, $"smtp_client_{date:yyyy-MM-dd}.log");
    }

    /// <summary>
    /// Logs a message with the specified log level.
    /// </summary>
    public static void Log(string message, LogLevel level = LogLevel.Info)
    {
        if (!_isEnabled && level != LogLevel.Error)
        {
            return;
        }

        var timestamp = DateTime.Now;
        var logEntry = $"[{timestamp:yyyy-MM-dd HH:mm:ss.fff}] [{level.ToString().ToUpper()}] {message}";

        // Add to recent logs for in-memory access
        RecentLogs.Enqueue(logEntry);
        while (RecentLogs.Count > MaxRecentLogs)
        {
            RecentLogs.TryDequeue(out _);
        }

        // Write to file
        try
        {
            lock (LockObject)
            {
                EnsureLogDirectoryExists();
                File.AppendAllText(GetLogFilePath(timestamp), logEntry + Environment.NewLine);
            }
        }
        catch
        {
            // Silently fail if we can't write to the log file
        }
    }

    /// <summary>
    /// Logs an email send attempt.
    /// </summary>
    public static void LogEmailAttempt(string server, int port, string from, string to, bool useTls)
    {
        var sb = new StringBuilder();
        sb.Append("Email send attempt - ");
        sb.Append($"Server: {server}:{port}, ");
        sb.Append($"From: {from}, ");
        sb.Append($"To: {to}, ");
        sb.Append($"TLS: {(useTls ? "Yes" : "No")}");

        Log(sb.ToString(), LogLevel.Info);
    }

    /// <summary>
    /// Logs a successful email send.
    /// </summary>
    public static void LogEmailSuccess(string server, string to)
    {
        Log($"Email sent successfully to {to} via {server}", LogLevel.Info);
    }

    /// <summary>
    /// Logs an email send failure.
    /// </summary>
    public static void LogEmailFailure(string server, string to, string error)
    {
        Log($"Email send failed to {to} via {server}: {error}", LogLevel.Error);
    }

    /// <summary>
    /// Logs a connection attempt.
    /// </summary>
    public static void LogConnectionAttempt(string server, int port)
    {
        Log($"Connecting to {server}:{port}...", LogLevel.Info);
    }

    /// <summary>
    /// Logs a successful connection.
    /// </summary>
    public static void LogConnectionSuccess(string server, int port)
    {
        Log($"Connected to {server}:{port}", LogLevel.Info);
    }

    /// <summary>
    /// Logs an authentication attempt.
    /// </summary>
    public static void LogAuthenticationAttempt(string username)
    {
        Log($"Authenticating as {username}...", LogLevel.Info);
    }

    /// <summary>
    /// Logs a successful authentication.
    /// </summary>
    public static void LogAuthenticationSuccess(string username)
    {
        Log($"Authentication successful for {username}", LogLevel.Info);
    }

    /// <summary>
    /// Gets recent log entries.
    /// </summary>
    public static string[] GetRecentLogs()
    {
        return [.. RecentLogs];
    }

    /// <summary>
    /// Reads the current day's log file.
    /// </summary>
    public static string ReadTodaysLog()
    {
        try
        {
            var logPath = GetLogFilePath(DateTime.Now);
            if (File.Exists(logPath))
            {
                return File.ReadAllText(logPath);
            }
        }
        catch (Exception ex)
        {
            return $"Error reading log file: {ex.Message}";
        }

        return "No log entries for today.";
    }

    /// <summary>
    /// Opens the log directory in File Explorer.
    /// </summary>
    public static void OpenLogDirectory()
    {
        try
        {
            EnsureLogDirectoryExists();
            System.Diagnostics.Process.Start("explorer.exe", LogDirectory);
        }
        catch (Exception ex)
        {
            Log($"Failed to open log directory: {ex.Message}", LogLevel.Error);
        }
    }

    /// <summary>
    /// Cleans up old log files (older than specified days).
    /// </summary>
    public static void CleanupOldLogs(int keepDays = 30)
    {
        try
        {
            if (!Directory.Exists(LogDirectory))
            {
                return;
            }

            var cutoffDate = DateTime.Now.AddDays(-keepDays);
            var logFiles = Directory.GetFiles(LogDirectory, "smtp_client_*.log");

            foreach (var file in logFiles)
            {
                var fileInfo = new FileInfo(file);
                if (fileInfo.CreationTime < cutoffDate)
                {
                    File.Delete(file);
                    Log($"Deleted old log file: {fileInfo.Name}", LogLevel.Debug);
                }
            }
        }
        catch (Exception ex)
        {
            Log($"Failed to cleanup old logs: {ex.Message}", LogLevel.Warning);
        }
    }

    private static void EnsureLogDirectoryExists()
    {
        if (!Directory.Exists(LogDirectory))
        {
            Directory.CreateDirectory(LogDirectory);
        }
    }
}
