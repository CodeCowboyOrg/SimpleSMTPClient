namespace SimpleSmtpClient
{
    partial class mainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.serverGroup = new System.Windows.Forms.GroupBox();
            this.guiIsBodyHTML = new System.Windows.Forms.CheckBox();
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
            this.serverGroup.SuspendLayout();
            this.emailGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // serverGroup
            // 
            this.serverGroup.Controls.Add(this.guiIsBodyHTML);
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
            this.serverGroup.Location = new System.Drawing.Point(16, 23);
            this.serverGroup.Margin = new System.Windows.Forms.Padding(4);
            this.serverGroup.Name = "serverGroup";
            this.serverGroup.Padding = new System.Windows.Forms.Padding(4);
            this.serverGroup.Size = new System.Drawing.Size(720, 164);
            this.serverGroup.TabIndex = 0;
            this.serverGroup.TabStop = false;
            this.serverGroup.Text = "SMTP Configuration";
            // 
            // guiIsBodyHTML
            // 
            this.guiIsBodyHTML.AutoSize = true;
            this.guiIsBodyHTML.Location = new System.Drawing.Point(206, 111);
            this.guiIsBodyHTML.Margin = new System.Windows.Forms.Padding(4);
            this.guiIsBodyHTML.Name = "guiIsBodyHTML";
            this.guiIsBodyHTML.Size = new System.Drawing.Size(118, 21);
            this.guiIsBodyHTML.TabIndex = 9;
            this.guiIsBodyHTML.Text = "Is Body HTML";
            this.guiIsBodyHTML.UseVisualStyleBackColor = true;
            // 
            // guiUseSsl
            // 
            this.guiUseSsl.AutoSize = true;
            this.guiUseSsl.Location = new System.Drawing.Point(32, 110);
            this.guiUseSsl.Margin = new System.Windows.Forms.Padding(4);
            this.guiUseSsl.Name = "guiUseSsl";
            this.guiUseSsl.Size = new System.Drawing.Size(85, 21);
            this.guiUseSsl.TabIndex = 9;
            this.guiUseSsl.Text = "Use SSL";
            this.guiUseSsl.UseVisualStyleBackColor = true;
            // 
            // guiPassword
            // 
            this.guiPassword.Location = new System.Drawing.Point(579, 81);
            this.guiPassword.Margin = new System.Windows.Forms.Padding(4);
            this.guiPassword.Name = "guiPassword";
            this.guiPassword.ReadOnly = true;
            this.guiPassword.Size = new System.Drawing.Size(115, 22);
            this.guiPassword.TabIndex = 8;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(504, 85);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(69, 17);
            this.lblPassword.TabIndex = 7;
            this.lblPassword.Text = "Password";
            // 
            // guiUser
            // 
            this.guiUser.Location = new System.Drawing.Point(289, 81);
            this.guiUser.Margin = new System.Windows.Forms.Padding(4);
            this.guiUser.Name = "guiUser";
            this.guiUser.ReadOnly = true;
            this.guiUser.Size = new System.Drawing.Size(204, 22);
            this.guiUser.TabIndex = 6;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(203, 85);
            this.lblUserName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(80, 17);
            this.lblUserName.TabIndex = 5;
            this.lblUserName.Text = "SMTP User";
            // 
            // guiUseCredentials
            // 
            this.guiUseCredentials.AutoSize = true;
            this.guiUseCredentials.Location = new System.Drawing.Point(32, 81);
            this.guiUseCredentials.Margin = new System.Windows.Forms.Padding(4);
            this.guiUseCredentials.Name = "guiUseCredentials";
            this.guiUseCredentials.Size = new System.Drawing.Size(149, 21);
            this.guiUseCredentials.TabIndex = 4;
            this.guiUseCredentials.Text = "Use Authentication";
            this.guiUseCredentials.UseVisualStyleBackColor = true;
            this.guiUseCredentials.CheckedChanged += new System.EventHandler(this.guiUseCredentials_CheckedChanged);
            // 
            // guiPort
            // 
            this.guiPort.Location = new System.Drawing.Point(599, 34);
            this.guiPort.Margin = new System.Windows.Forms.Padding(4);
            this.guiPort.Name = "guiPort";
            this.guiPort.Size = new System.Drawing.Size(96, 22);
            this.guiPort.TabIndex = 3;
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.Location = new System.Drawing.Point(559, 38);
            this.lblPort.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(34, 17);
            this.lblPort.TabIndex = 2;
            this.lblPort.Text = "Port";
            // 
            // guiServerName
            // 
            this.guiServerName.Location = new System.Drawing.Point(128, 34);
            this.guiServerName.Margin = new System.Windows.Forms.Padding(4);
            this.guiServerName.Name = "guiServerName";
            this.guiServerName.Size = new System.Drawing.Size(384, 22);
            this.guiServerName.TabIndex = 1;
            // 
            // lblServerName
            // 
            this.lblServerName.AutoSize = true;
            this.lblServerName.Location = new System.Drawing.Point(29, 38);
            this.lblServerName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblServerName.Name = "lblServerName";
            this.lblServerName.Size = new System.Drawing.Size(92, 17);
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
            this.emailGroup.Location = new System.Drawing.Point(16, 209);
            this.emailGroup.Margin = new System.Windows.Forms.Padding(4);
            this.emailGroup.Name = "emailGroup";
            this.emailGroup.Padding = new System.Windows.Forms.Padding(4);
            this.emailGroup.Size = new System.Drawing.Size(719, 298);
            this.emailGroup.TabIndex = 1;
            this.emailGroup.TabStop = false;
            this.emailGroup.Text = "Email Message";
            // 
            // guiEmailBody
            // 
            this.guiEmailBody.Location = new System.Drawing.Point(101, 175);
            this.guiEmailBody.Margin = new System.Windows.Forms.Padding(4);
            this.guiEmailBody.Multiline = true;
            this.guiEmailBody.Name = "guiEmailBody";
            this.guiEmailBody.Size = new System.Drawing.Size(593, 94);
            this.guiEmailBody.TabIndex = 8;
            // 
            // lblBody
            // 
            this.lblBody.AutoSize = true;
            this.lblBody.Location = new System.Drawing.Point(29, 176);
            this.lblBody.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBody.Name = "lblBody";
            this.lblBody.Size = new System.Drawing.Size(40, 17);
            this.lblBody.TabIndex = 7;
            this.lblBody.Text = "Body";
            // 
            // guiEmailSubject
            // 
            this.guiEmailSubject.Location = new System.Drawing.Point(101, 128);
            this.guiEmailSubject.Margin = new System.Windows.Forms.Padding(4);
            this.guiEmailSubject.Name = "guiEmailSubject";
            this.guiEmailSubject.Size = new System.Drawing.Size(593, 22);
            this.guiEmailSubject.TabIndex = 6;
            // 
            // lblSubject
            // 
            this.lblSubject.AutoSize = true;
            this.lblSubject.Location = new System.Drawing.Point(29, 132);
            this.lblSubject.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(55, 17);
            this.lblSubject.TabIndex = 5;
            this.lblSubject.Text = "Subject";
            // 
            // guiEmailTo
            // 
            this.guiEmailTo.Location = new System.Drawing.Point(101, 81);
            this.guiEmailTo.Margin = new System.Windows.Forms.Padding(4);
            this.guiEmailTo.Name = "guiEmailTo";
            this.guiEmailTo.Size = new System.Drawing.Size(593, 22);
            this.guiEmailTo.TabIndex = 4;
            // 
            // lblEmailTo
            // 
            this.lblEmailTo.AutoSize = true;
            this.lblEmailTo.Location = new System.Drawing.Point(29, 85);
            this.lblEmailTo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmailTo.Name = "lblEmailTo";
            this.lblEmailTo.Size = new System.Drawing.Size(25, 17);
            this.lblEmailTo.TabIndex = 3;
            this.lblEmailTo.Text = "To";
            // 
            // guiEmailFrom
            // 
            this.guiEmailFrom.Location = new System.Drawing.Point(101, 34);
            this.guiEmailFrom.Margin = new System.Windows.Forms.Padding(4);
            this.guiEmailFrom.Name = "guiEmailFrom";
            this.guiEmailFrom.Size = new System.Drawing.Size(593, 22);
            this.guiEmailFrom.TabIndex = 2;
            // 
            // lblEmailFrom
            // 
            this.lblEmailFrom.AutoSize = true;
            this.lblEmailFrom.Location = new System.Drawing.Point(29, 37);
            this.lblEmailFrom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmailFrom.Name = "lblEmailFrom";
            this.lblEmailFrom.Size = new System.Drawing.Size(40, 17);
            this.lblEmailFrom.TabIndex = 1;
            this.lblEmailFrom.Text = "From";
            // 
            // guiSendMail
            // 
            this.guiSendMail.Location = new System.Drawing.Point(595, 526);
            this.guiSendMail.Margin = new System.Windows.Forms.Padding(4);
            this.guiSendMail.Name = "guiSendMail";
            this.guiSendMail.Size = new System.Drawing.Size(139, 38);
            this.guiSendMail.TabIndex = 2;
            this.guiSendMail.Text = "Send Mail";
            this.guiSendMail.UseVisualStyleBackColor = true;
            this.guiSendMail.Click += new System.EventHandler(this.guiSendMail_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 578);
            this.Controls.Add(this.guiSendMail);
            this.Controls.Add(this.emailGroup);
            this.Controls.Add(this.serverGroup);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "mainForm";
            this.Text = "Simple SMTP Client";
            this.serverGroup.ResumeLayout(false);
            this.serverGroup.PerformLayout();
            this.emailGroup.ResumeLayout(false);
            this.emailGroup.PerformLayout();
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
        private System.Windows.Forms.CheckBox guiIsBodyHTML;
    }
}

