﻿namespace SimpleSmtpClient
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
            this.guiReplyTo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.guiHeader = new System.Windows.Forms.TextBox();
            this.guiHeaderValue = new System.Windows.Forms.TextBox();
            this.serverGroup.SuspendLayout();
            this.emailGroup.SuspendLayout();
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
            this.serverGroup.Location = new System.Drawing.Point(12, 19);
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
            this.lblSSLVersion.Size = new System.Drawing.Size(96, 13);
            this.lblSSLVersion.TabIndex = 10;
            this.lblSSLVersion.Text = "SSL / TLS Version";
            // 
            // cmbSSLVersion
            // 
            this.cmbSSLVersion.FormattingEnabled = true;
            this.cmbSSLVersion.Items.AddRange(new object[] {
            "Auto",
            "SSL3",
            "TLS 1.0",
            "TLS 1.1",
            "TLS 1.2"});
            this.cmbSSLVersion.Location = new System.Drawing.Point(400, 95);
            this.cmbSSLVersion.Name = "cmbSSLVersion";
            this.cmbSSLVersion.Size = new System.Drawing.Size(121, 21);
            this.cmbSSLVersion.TabIndex = 7;
            // 
            // guiUseSsl
            // 
            this.guiUseSsl.AutoSize = true;
            this.guiUseSsl.Location = new System.Drawing.Point(25, 97);
            this.guiUseSsl.Name = "guiUseSsl";
            this.guiUseSsl.Size = new System.Drawing.Size(68, 17);
            this.guiUseSsl.TabIndex = 6;
            this.guiUseSsl.Text = "Use SSL";
            this.guiUseSsl.UseVisualStyleBackColor = true;
            // 
            // guiPassword
            // 
            this.guiPassword.Location = new System.Drawing.Point(434, 66);
            this.guiPassword.Name = "guiPassword";
            this.guiPassword.ReadOnly = true;
            this.guiPassword.Size = new System.Drawing.Size(87, 20);
            this.guiPassword.TabIndex = 5;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(378, 69);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(53, 13);
            this.lblPassword.TabIndex = 7;
            this.lblPassword.Text = "Password";
            // 
            // guiUser
            // 
            this.guiUser.Location = new System.Drawing.Point(217, 66);
            this.guiUser.Name = "guiUser";
            this.guiUser.ReadOnly = true;
            this.guiUser.Size = new System.Drawing.Size(154, 20);
            this.guiUser.TabIndex = 4;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(152, 69);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(62, 13);
            this.lblUserName.TabIndex = 5;
            this.lblUserName.Text = "SMTP User";
            // 
            // guiUseCredentials
            // 
            this.guiUseCredentials.AutoSize = true;
            this.guiUseCredentials.Location = new System.Drawing.Point(25, 69);
            this.guiUseCredentials.Name = "guiUseCredentials";
            this.guiUseCredentials.Size = new System.Drawing.Size(116, 17);
            this.guiUseCredentials.TabIndex = 3;
            this.guiUseCredentials.Text = "Use Authentication";
            this.guiUseCredentials.UseVisualStyleBackColor = true;
            this.guiUseCredentials.CheckedChanged += new System.EventHandler(this.guiUseCredentials_CheckedChanged);
            // 
            // guiPort
            // 
            this.guiPort.Location = new System.Drawing.Point(449, 28);
            this.guiPort.Name = "guiPort";
            this.guiPort.Size = new System.Drawing.Size(73, 20);
            this.guiPort.TabIndex = 2;
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.Location = new System.Drawing.Point(419, 31);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(26, 13);
            this.lblPort.TabIndex = 2;
            this.lblPort.Text = "Port";
            // 
            // guiServerName
            // 
            this.guiServerName.Location = new System.Drawing.Point(96, 28);
            this.guiServerName.Name = "guiServerName";
            this.guiServerName.Size = new System.Drawing.Size(289, 20);
            this.guiServerName.TabIndex = 1;
            // 
            // lblServerName
            // 
            this.lblServerName.AutoSize = true;
            this.lblServerName.Location = new System.Drawing.Point(22, 31);
            this.lblServerName.Name = "lblServerName";
            this.lblServerName.Size = new System.Drawing.Size(71, 13);
            this.lblServerName.TabIndex = 0;
            this.lblServerName.Text = "SMTP Server";
            // 
            // emailGroup
            // 
            this.emailGroup.Controls.Add(this.guiHeaderValue);
            this.emailGroup.Controls.Add(this.guiHeader);
            this.emailGroup.Controls.Add(this.label2);
            this.emailGroup.Controls.Add(this.guiReplyTo);
            this.emailGroup.Controls.Add(this.label1);
            this.emailGroup.Controls.Add(this.guiEmailBody);
            this.emailGroup.Controls.Add(this.lblBody);
            this.emailGroup.Controls.Add(this.guiEmailSubject);
            this.emailGroup.Controls.Add(this.lblSubject);
            this.emailGroup.Controls.Add(this.guiEmailTo);
            this.emailGroup.Controls.Add(this.lblEmailTo);
            this.emailGroup.Controls.Add(this.guiEmailFrom);
            this.emailGroup.Controls.Add(this.lblEmailFrom);
            this.emailGroup.Location = new System.Drawing.Point(12, 170);
            this.emailGroup.Name = "emailGroup";
            this.emailGroup.Size = new System.Drawing.Size(539, 345);
            this.emailGroup.TabIndex = 1;
            this.emailGroup.TabStop = false;
            this.emailGroup.Text = "Email Message";
            // 
            // guiEmailBody
            // 
            this.guiEmailBody.Location = new System.Drawing.Point(76, 181);
            this.guiEmailBody.Multiline = true;
            this.guiEmailBody.Name = "guiEmailBody";
            this.guiEmailBody.Size = new System.Drawing.Size(446, 77);
            this.guiEmailBody.TabIndex = 11;
            // 
            // lblBody
            // 
            this.lblBody.AutoSize = true;
            this.lblBody.Location = new System.Drawing.Point(22, 182);
            this.lblBody.Name = "lblBody";
            this.lblBody.Size = new System.Drawing.Size(31, 13);
            this.lblBody.TabIndex = 7;
            this.lblBody.Text = "Body";
            // 
            // guiEmailSubject
            // 
            this.guiEmailSubject.Location = new System.Drawing.Point(76, 143);
            this.guiEmailSubject.Name = "guiEmailSubject";
            this.guiEmailSubject.Size = new System.Drawing.Size(446, 20);
            this.guiEmailSubject.TabIndex = 10;
            // 
            // lblSubject
            // 
            this.lblSubject.AutoSize = true;
            this.lblSubject.Location = new System.Drawing.Point(22, 146);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(43, 13);
            this.lblSubject.TabIndex = 5;
            this.lblSubject.Text = "Subject";
            // 
            // guiEmailTo
            // 
            this.guiEmailTo.Location = new System.Drawing.Point(76, 66);
            this.guiEmailTo.Name = "guiEmailTo";
            this.guiEmailTo.Size = new System.Drawing.Size(446, 20);
            this.guiEmailTo.TabIndex = 9;
            // 
            // lblEmailTo
            // 
            this.lblEmailTo.AutoSize = true;
            this.lblEmailTo.Location = new System.Drawing.Point(22, 69);
            this.lblEmailTo.Name = "lblEmailTo";
            this.lblEmailTo.Size = new System.Drawing.Size(20, 13);
            this.lblEmailTo.TabIndex = 3;
            this.lblEmailTo.Text = "To";
            // 
            // guiEmailFrom
            // 
            this.guiEmailFrom.Location = new System.Drawing.Point(76, 28);
            this.guiEmailFrom.Name = "guiEmailFrom";
            this.guiEmailFrom.Size = new System.Drawing.Size(446, 20);
            this.guiEmailFrom.TabIndex = 8;
            // 
            // lblEmailFrom
            // 
            this.lblEmailFrom.AutoSize = true;
            this.lblEmailFrom.Location = new System.Drawing.Point(22, 30);
            this.lblEmailFrom.Name = "lblEmailFrom";
            this.lblEmailFrom.Size = new System.Drawing.Size(30, 13);
            this.lblEmailFrom.TabIndex = 1;
            this.lblEmailFrom.Text = "From";
            // 
            // guiSendMail
            // 
            this.guiSendMail.Location = new System.Drawing.Point(446, 535);
            this.guiSendMail.Name = "guiSendMail";
            this.guiSendMail.Size = new System.Drawing.Size(104, 31);
            this.guiSendMail.TabIndex = 12;
            this.guiSendMail.Text = "Send Mail";
            this.guiSendMail.UseVisualStyleBackColor = true;
            this.guiSendMail.Click += new System.EventHandler(this.guiSendMail_Click);
            // 
            // guiReplyTo
            // 
            this.guiReplyTo.Location = new System.Drawing.Point(76, 106);
            this.guiReplyTo.Name = "guiReplyTo";
            this.guiReplyTo.Size = new System.Drawing.Size(446, 20);
            this.guiReplyTo.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Reply-To";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 281);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Optional Headers";
            // 
            // guiHeader
            // 
            this.guiHeader.Location = new System.Drawing.Point(76, 307);
            this.guiHeader.Name = "guiHeader";
            this.guiHeader.Size = new System.Drawing.Size(206, 20);
            this.guiHeader.TabIndex = 15;
            // 
            // guiHeaderValue
            // 
            this.guiHeaderValue.Location = new System.Drawing.Point(288, 307);
            this.guiHeaderValue.Name = "guiHeaderValue";
            this.guiHeaderValue.Size = new System.Drawing.Size(233, 20);
            this.guiHeaderValue.TabIndex = 16;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 609);
            this.Controls.Add(this.guiSendMail);
            this.Controls.Add(this.emailGroup);
            this.Controls.Add(this.serverGroup);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
        private System.Windows.Forms.Label lblSSLVersion;
        private System.Windows.Forms.ComboBox cmbSSLVersion;
        private System.Windows.Forms.TextBox guiReplyTo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox guiHeaderValue;
        private System.Windows.Forms.TextBox guiHeader;
        private System.Windows.Forms.Label label2;
    }
}

