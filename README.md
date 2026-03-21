# Simple SMTP Client

## A simple and to the point SMTP test client

**Built with .NET 10** - Modern, fast, and secure!

### Features

1. Download the release under the "release" tab.
2. Supports Basic Authentication to SMTP server.
3. Supports Anonymous connection to SMTP Server.
4. **Supports TLS/SSL encryption** with modern MailKit library:
   - TLS 1.0, TLS 1.1, TLS 1.2, and TLS 1.3 (automatically negotiated)
   - Auto/System Default mode for automatic protocol negotiation
   - Secure by default with TLS 1.2+ recommended
   - Works with SMTP servers in STARTTLS mode only. Does not support connecting to SMTP/SSL, SMTP over SSL, or SMTPS server on default port 465.
5. Runs on Windows (requires .NET 10 Runtime or later).
6. **Modern async/await** implementation for better performance and responsiveness.
7. **Input validation** for all required fields with helpful error messages.
8. **Configurable connection timeout** (5-300 seconds) with ability to cancel ongoing operations.
9. **Save/Load settings** - Your SMTP server configuration is automatically saved and restored between sessions.
10. **Logging feature** - All connection attempts, successes, and failures are logged to daily log files:
    - View logs directly in the application
    - Open log folder in File Explorer
    - Automatic cleanup of logs older than 30 days
    - Toggle logging on/off as needed

### Settings Storage

Settings and logs are stored in:
- Windows: `%LOCALAPPDATA%\SimpleSmtpClient\`
  - `settings.json` - Application settings
  - `Logs\` - Daily log files

**Note:** Passwords are never saved to disk for security reasons.

![Image of Software](https://i.imgur.com/fFRQPxg.png)
