namespace SimpleSmtpClient;

partial class MainForm
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
        this.serverGroup = new System.Windows.Forms.GroupBox();
        this.lblSSLVersion = new System.Windows.Forms.Label();
        this.cmbSSLVersion = new System.Windows.Forms.ComboBox();
        this.guiUseSsl = new System.Windows.Forms.CheckBox();
        this.guiPassword = new System.Windows.Forms.TextBox();
        this.lblPassword = new System.Windows.Forms.Label();
        this.guiUser = new System.Windows.Forms.TextBox();
        this.lblUserName = new System.Windows.Forms.Label();
        this.guiUseCredentials = new System.Windows.Forms.CheckBox();
        this.guiPort = new System.Windows.Forms.TextBox();
        this.lblPort = new System.Windows.Forms.Label();
        this.guiServerName = new System.Windows.Forms.TextBox();
        this.lblServerName = new System.Windows.Forms.Label();
        this.emailGroup = new System.Windows.Forms.GroupBox();
        this.guiEmailBody = new System.Windows.Forms.TextBox();
        this.lblBody = new System.Windows.Forms.Label();
        this.guiEmailSubject = new System.Windows.Forms.TextBox();
        this.lblSubject = new System.Windows.Forms.Label();
        this.guiEmailTo = new System.Windows.Forms.TextBox();
        this.lblEmailTo = new System.Windows.Forms.Label();
        this.guiEmailFrom = new System.Windows.Forms.TextBox();
        this.lblEmailFrom = new System.Windows.Forms.Label();
        this.guiSendMail = new System.Windows.Forms.Button();
        this.btnCancel = new System.Windows.Forms.Button();
        this.optionsGroup = new System.Windows.Forms.GroupBox();
        this.btnOpenLogFolder = new System.Windows.Forms.Button();
        this.btnViewLog = new System.Windows.Forms.Button();
        this.chkEnableLogging = new System.Windows.Forms.CheckBox();
        this.lblTimeout = new System.Windows.Forms.Label();
        this.numTimeout = new System.Windows.Forms.NumericUpDown();
        this.lblTimeoutSeconds = new System.Windows.Forms.Label();
        this.serverGroup.SuspendLayout();
        this.emailGroup.SuspendLayout();
        this.optionsGroup.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)(this.numTimeout)).BeginInit();
        this.SuspendLayout();
        // 
        // serverGroup
        // 
        this.serverGroup.Controls.Add(this.lblSSLVersion);
        this.serverGroup.Controls.Add(this.cmbSSLVersion);
        this.serverGroup.Controls.Add(this.guiUseSsl);
        this.serverGroup.Controls.Add(this.guiPassword);
        this.serverGroup.Controls.Add(this.lblPassword);
        this.serverGroup.Controls.Add(this.guiUser);
        this.serverGroup.Controls.Add(this.lblUserName);
        this.serverGroup.Controls.Add(this.guiUseCredentials);
        this.serverGroup.Controls.Add(this.guiPort);
        this.serverGroup.Controls.Add(this.lblPort);
        this.serverGroup.Controls.Add(this.guiServerName);
        this.serverGroup.Controls.Add(this.lblServerName);
        this.serverGroup.Location = new System.Drawing.Point(12, 12);
        this.serverGroup.Name = "serverGroup";
        this.serverGroup.Size = new System.Drawing.Size(540, 133);
        this.serverGroup.TabIndex = 0;
        this.serverGroup.TabStop = false;
        this.serverGroup.Text = "SMTP Configuration";
        // 
        // lblSSLVersion
        // 
        this.lblSSLVersion.AutoSize = true;
        this.lblSSLVersion.Location = new System.Drawing.Point(298, 98);
        this.lblSSLVersion.Name = "lblSSLVersion";
        this.lblSSLVersion.Size = new System.Drawing.Size(68, 15);
        this.lblSSLVersion.TabIndex = 10;
        this.lblSSLVersion.Text = "TLS Version";
        // 
        // cmbSSLVersion
        // 
        this.cmbSSLVersion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        this.cmbSSLVersion.FormattingEnabled = true;
        this.cmbSSLVersion.Items.AddRange(new object[] {
            "Auto (System Default)",
            "TLS 1.0",
            "TLS 1.1",
            "TLS 1.2",
            "TLS 1.3"});
        this.cmbSSLVersion.Location = new System.Drawing.Point(372, 95);
        this.cmbSSLVersion.Name = "cmbSSLVersion";
        this.cmbSSLVersion.Size = new System.Drawing.Size(149, 23);
        this.cmbSSLVersion.TabIndex = 7;
        // 
        // guiUseSsl
        // 
        this.guiUseSsl.AutoSize = true;
        this.guiUseSsl.Location = new System.Drawing.Point(25, 97);
        this.guiUseSsl.Name = "guiUseSsl";
        this.guiUseSsl.Size = new System.Drawing.Size(94, 19);
        this.guiUseSsl.TabIndex = 6;
        this.guiUseSsl.Text = "Use TLS/SSL";
        this.guiUseSsl.UseVisualStyleBackColor = true;
        this.guiUseSsl.CheckedChanged += new System.EventHandler(this.guiUseSsl_CheckedChanged);
        // 
        // guiPassword
        // 
        this.guiPassword.Location = new System.Drawing.Point(434, 59);
        this.guiPassword.Name = "guiPassword";
        this.guiPassword.PasswordChar = '●';
        this.guiPassword.ReadOnly = true;
        this.guiPassword.Size = new System.Drawing.Size(87, 23);
        this.guiPassword.TabIndex = 5;
        // 
        // lblPassword
        // 
        this.lblPassword.AutoSize = true;
        this.lblPassword.Location = new System.Drawing.Point(370, 62);
        this.lblPassword.Name = "lblPassword";
        this.lblPassword.Size = new System.Drawing.Size(57, 15);
        this.lblPassword.TabIndex = 7;
        this.lblPassword.Text = "Password";
        // 
        // guiUser
        // 
        this.guiUser.Location = new System.Drawing.Point(217, 59);
        this.guiUser.Name = "guiUser";
        this.guiUser.ReadOnly = true;
        this.guiUser.Size = new System.Drawing.Size(147, 23);
        this.guiUser.TabIndex = 4;
        // 
        // lblUserName
        // 
        this.lblUserName.AutoSize = true;
        this.lblUserName.Location = new System.Drawing.Point(152, 62);
        this.lblUserName.Name = "lblUserName";
        this.lblUserName.Size = new System.Drawing.Size(62, 15);
        this.lblUserName.TabIndex = 5;
        this.lblUserName.Text = "SMTP User";
        // 
        // guiUseCredentials
        // 
        this.guiUseCredentials.AutoSize = true;
        this.guiUseCredentials.Location = new System.Drawing.Point(25, 62);
        this.guiUseCredentials.Name = "guiUseCredentials";
        this.guiUseCredentials.Size = new System.Drawing.Size(121, 19);
        this.guiUseCredentials.TabIndex = 3;
        this.guiUseCredentials.Text = "Use Authentication";
        this.guiUseCredentials.UseVisualStyleBackColor = true;
        this.guiUseCredentials.CheckedChanged += new System.EventHandler(this.guiUseCredentials_CheckedChanged);
        // 
        // guiPort
        // 
        this.guiPort.Location = new System.Drawing.Point(449, 22);
        this.guiPort.Name = "guiPort";
        this.guiPort.Size = new System.Drawing.Size(73, 23);
        this.guiPort.TabIndex = 2;
        this.guiPort.Text = "587";
        // 
        // lblPort
        // 
        this.lblPort.AutoSize = true;
        this.lblPort.Location = new System.Drawing.Point(419, 25);
        this.lblPort.Name = "lblPort";
        this.lblPort.Size = new System.Drawing.Size(29, 15);
        this.lblPort.TabIndex = 2;
        this.lblPort.Text = "Port";
        // 
        // guiServerName
        // 
        this.guiServerName.Location = new System.Drawing.Point(96, 22);
        this.guiServerName.Name = "guiServerName";
        this.guiServerName.Size = new System.Drawing.Size(289, 23);
        this.guiServerName.TabIndex = 1;
        // 
        // lblServerName
        // 
        this.lblServerName.AutoSize = true;
        this.lblServerName.Location = new System.Drawing.Point(22, 25);
        this.lblServerName.Name = "lblServerName";
        this.lblServerName.Size = new System.Drawing.Size(72, 15);
        this.lblServerName.TabIndex = 0;
        this.lblServerName.Text = "SMTP Server";
        // 
        // emailGroup
        // 
        this.emailGroup.Controls.Add(this.guiEmailBody);
        this.emailGroup.Controls.Add(this.lblBody);
        this.emailGroup.Controls.Add(this.guiEmailSubject);
        this.emailGroup.Controls.Add(this.lblSubject);
        this.emailGroup.Controls.Add(this.guiEmailTo);
        this.emailGroup.Controls.Add(this.lblEmailTo);
        this.emailGroup.Controls.Add(this.guiEmailFrom);
        this.emailGroup.Controls.Add(this.lblEmailFrom);
        this.emailGroup.Location = new System.Drawing.Point(12, 151);
        this.emailGroup.Name = "emailGroup";
        this.emailGroup.Size = new System.Drawing.Size(540, 220);
        this.emailGroup.TabIndex = 1;
        this.emailGroup.TabStop = false;
        this.emailGroup.Text = "Email Message";
        // 
        // guiEmailBody
        // 
        this.guiEmailBody.Location = new System.Drawing.Point(76, 120);
        this.guiEmailBody.Multiline = true;
        this.guiEmailBody.Name = "guiEmailBody";
        this.guiEmailBody.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
        this.guiEmailBody.Size = new System.Drawing.Size(446, 85);
        this.guiEmailBody.TabIndex = 11;
        // 
        // lblBody
        // 
        this.lblBody.AutoSize = true;
        this.lblBody.Location = new System.Drawing.Point(22, 123);
        this.lblBody.Name = "lblBody";
        this.lblBody.Size = new System.Drawing.Size(34, 15);
        this.lblBody.TabIndex = 7;
        this.lblBody.Text = "Body";
        // 
        // guiEmailSubject
        // 
        this.guiEmailSubject.Location = new System.Drawing.Point(76, 88);
        this.guiEmailSubject.Name = "guiEmailSubject";
        this.guiEmailSubject.Size = new System.Drawing.Size(446, 23);
        this.guiEmailSubject.TabIndex = 10;
        // 
        // lblSubject
        // 
        this.lblSubject.AutoSize = true;
        this.lblSubject.Location = new System.Drawing.Point(22, 91);
        this.lblSubject.Name = "lblSubject";
        this.lblSubject.Size = new System.Drawing.Size(46, 15);
        this.lblSubject.TabIndex = 5;
        this.lblSubject.Text = "Subject";
        // 
        // guiEmailTo
        // 
        this.guiEmailTo.Location = new System.Drawing.Point(76, 55);
        this.guiEmailTo.Name = "guiEmailTo";
        this.guiEmailTo.Size = new System.Drawing.Size(446, 23);
        this.guiEmailTo.TabIndex = 9;
        // 
        // lblEmailTo
        // 
        this.lblEmailTo.AutoSize = true;
        this.lblEmailTo.Location = new System.Drawing.Point(22, 58);
        this.lblEmailTo.Name = "lblEmailTo";
        this.lblEmailTo.Size = new System.Drawing.Size(19, 15);
        this.lblEmailTo.TabIndex = 3;
        this.lblEmailTo.Text = "To";
        // 
        // guiEmailFrom
        // 
        this.guiEmailFrom.Location = new System.Drawing.Point(76, 22);
        this.guiEmailFrom.Name = "guiEmailFrom";
        this.guiEmailFrom.Size = new System.Drawing.Size(446, 23);
        this.guiEmailFrom.TabIndex = 8;
        // 
        // lblEmailFrom
        // 
        this.lblEmailFrom.AutoSize = true;
        this.lblEmailFrom.Location = new System.Drawing.Point(22, 25);
        this.lblEmailFrom.Name = "lblEmailFrom";
        this.lblEmailFrom.Size = new System.Drawing.Size(35, 15);
        this.lblEmailFrom.TabIndex = 1;
        this.lblEmailFrom.Text = "From";
        // 
        // guiSendMail
        // 
        this.guiSendMail.Location = new System.Drawing.Point(448, 454);
        this.guiSendMail.Name = "guiSendMail";
        this.guiSendMail.Size = new System.Drawing.Size(104, 31);
        this.guiSendMail.TabIndex = 12;
        this.guiSendMail.Text = "Send Mail";
        this.guiSendMail.UseVisualStyleBackColor = true;
        this.guiSendMail.Click += new System.EventHandler(this.guiSendMail_Click);
        // 
        // btnCancel
        // 
        this.btnCancel.Location = new System.Drawing.Point(338, 454);
        this.btnCancel.Name = "btnCancel";
        this.btnCancel.Size = new System.Drawing.Size(104, 31);
        this.btnCancel.TabIndex = 13;
        this.btnCancel.Text = "Cancel";
        this.btnCancel.UseVisualStyleBackColor = true;
        this.btnCancel.Visible = false;
        this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
        // 
        // optionsGroup
        // 
        this.optionsGroup.Controls.Add(this.lblTimeoutSeconds);
        this.optionsGroup.Controls.Add(this.btnOpenLogFolder);
        this.optionsGroup.Controls.Add(this.btnViewLog);
        this.optionsGroup.Controls.Add(this.chkEnableLogging);
        this.optionsGroup.Controls.Add(this.lblTimeout);
        this.optionsGroup.Controls.Add(this.numTimeout);
        this.optionsGroup.Location = new System.Drawing.Point(12, 377);
        this.optionsGroup.Name = "optionsGroup";
        this.optionsGroup.Size = new System.Drawing.Size(540, 66);
        this.optionsGroup.TabIndex = 2;
        this.optionsGroup.TabStop = false;
        this.optionsGroup.Text = "Options";
        // 
        // btnOpenLogFolder
        // 
        this.btnOpenLogFolder.Location = new System.Drawing.Point(434, 26);
        this.btnOpenLogFolder.Name = "btnOpenLogFolder";
        this.btnOpenLogFolder.Size = new System.Drawing.Size(88, 27);
        this.btnOpenLogFolder.TabIndex = 5;
        this.btnOpenLogFolder.Text = "Open Folder";
        this.btnOpenLogFolder.UseVisualStyleBackColor = true;
        this.btnOpenLogFolder.Click += new System.EventHandler(this.btnOpenLogFolder_Click);
        // 
        // btnViewLog
        // 
        this.btnViewLog.Location = new System.Drawing.Point(340, 26);
        this.btnViewLog.Name = "btnViewLog";
        this.btnViewLog.Size = new System.Drawing.Size(88, 27);
        this.btnViewLog.TabIndex = 4;
        this.btnViewLog.Text = "View Log";
        this.btnViewLog.UseVisualStyleBackColor = true;
        this.btnViewLog.Click += new System.EventHandler(this.btnViewLog_Click);
        // 
        // chkEnableLogging
        // 
        this.chkEnableLogging.AutoSize = true;
        this.chkEnableLogging.Checked = true;
        this.chkEnableLogging.CheckState = System.Windows.Forms.CheckState.Checked;
        this.chkEnableLogging.Location = new System.Drawing.Point(217, 30);
        this.chkEnableLogging.Name = "chkEnableLogging";
        this.chkEnableLogging.Size = new System.Drawing.Size(108, 19);
        this.chkEnableLogging.TabIndex = 3;
        this.chkEnableLogging.Text = "Enable Logging";
        this.chkEnableLogging.UseVisualStyleBackColor = true;
        this.chkEnableLogging.CheckedChanged += new System.EventHandler(this.chkEnableLogging_CheckedChanged);
        // 
        // lblTimeout
        // 
        this.lblTimeout.AutoSize = true;
        this.lblTimeout.Location = new System.Drawing.Point(22, 31);
        this.lblTimeout.Name = "lblTimeout";
        this.lblTimeout.Size = new System.Drawing.Size(51, 15);
        this.lblTimeout.TabIndex = 1;
        this.lblTimeout.Text = "Timeout";
        // 
        // numTimeout
        // 
        this.numTimeout.Location = new System.Drawing.Point(79, 28);
        this.numTimeout.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
        this.numTimeout.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
        this.numTimeout.Name = "numTimeout";
        this.numTimeout.Size = new System.Drawing.Size(60, 23);
        this.numTimeout.TabIndex = 2;
        this.numTimeout.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
        // 
        // lblTimeoutSeconds
        // 
        this.lblTimeoutSeconds.AutoSize = true;
        this.lblTimeoutSeconds.Location = new System.Drawing.Point(145, 31);
        this.lblTimeoutSeconds.Name = "lblTimeoutSeconds";
        this.lblTimeoutSeconds.Size = new System.Drawing.Size(50, 15);
        this.lblTimeoutSeconds.TabIndex = 6;
        this.lblTimeoutSeconds.Text = "seconds";
        // 
        // MainForm
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(564, 496);
        this.Controls.Add(this.optionsGroup);
        this.Controls.Add(this.btnCancel);
        this.Controls.Add(this.guiSendMail);
        this.Controls.Add(this.emailGroup);
        this.Controls.Add(this.serverGroup);
        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
        this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
        this.MaximizeBox = false;
        this.Name = "MainForm";
        this.Text = "Simple SMTP Client";
        this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
        this.Load += new System.EventHandler(this.MainForm_Load);
        this.serverGroup.ResumeLayout(false);
        this.serverGroup.PerformLayout();
        this.emailGroup.ResumeLayout(false);
        this.emailGroup.PerformLayout();
        this.optionsGroup.ResumeLayout(false);
        this.optionsGroup.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)(this.numTimeout)).EndInit();
        this.ResumeLayout(false);
    }

    #endregion

    private System.Windows.Forms.GroupBox serverGroup;
    private System.Windows.Forms.TextBox guiPassword;
    private System.Windows.Forms.Label lblPassword;
    private System.Windows.Forms.TextBox guiUser;
    private System.Windows.Forms.Label lblUserName;
    private System.Windows.Forms.CheckBox guiUseCredentials;
    private System.Windows.Forms.TextBox guiPort;
    private System.Windows.Forms.Label lblPort;
    private System.Windows.Forms.TextBox guiServerName;
    private System.Windows.Forms.Label lblServerName;
    private System.Windows.Forms.GroupBox emailGroup;
    private System.Windows.Forms.TextBox guiEmailBody;
    private System.Windows.Forms.Label lblBody;
    private System.Windows.Forms.TextBox guiEmailSubject;
    private System.Windows.Forms.Label lblSubject;
    private System.Windows.Forms.TextBox guiEmailTo;
    private System.Windows.Forms.Label lblEmailTo;
    private System.Windows.Forms.TextBox guiEmailFrom;
    private System.Windows.Forms.Label lblEmailFrom;
    private System.Windows.Forms.Button guiSendMail;
    private System.Windows.Forms.CheckBox guiUseSsl;
    private System.Windows.Forms.Label lblSSLVersion;
    private System.Windows.Forms.ComboBox cmbSSLVersion;
    private System.Windows.Forms.Button btnCancel;
    private System.Windows.Forms.GroupBox optionsGroup;
    private System.Windows.Forms.Label lblTimeout;
    private System.Windows.Forms.NumericUpDown numTimeout;
    private System.Windows.Forms.CheckBox chkEnableLogging;
    private System.Windows.Forms.Button btnViewLog;
    private System.Windows.Forms.Button btnOpenLogFolder;
    private System.Windows.Forms.Label lblTimeoutSeconds;
}
