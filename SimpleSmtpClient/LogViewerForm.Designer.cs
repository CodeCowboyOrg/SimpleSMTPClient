namespace SimpleSmtpClient;

partial class LogViewerForm
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
        this.txtLog = new System.Windows.Forms.TextBox();
        this.btnRefresh = new System.Windows.Forms.Button();
        this.btnClose = new System.Windows.Forms.Button();
        this.btnOpenFolder = new System.Windows.Forms.Button();
        this.SuspendLayout();
        // 
        // txtLog
        // 
        this.txtLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
        this.txtLog.BackColor = System.Drawing.Color.White;
        this.txtLog.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this.txtLog.Location = new System.Drawing.Point(12, 12);
        this.txtLog.Multiline = true;
        this.txtLog.Name = "txtLog";
        this.txtLog.ReadOnly = true;
        this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Both;
        this.txtLog.Size = new System.Drawing.Size(660, 387);
        this.txtLog.TabIndex = 0;
        this.txtLog.WordWrap = false;
        // 
        // btnRefresh
        // 
        this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
        this.btnRefresh.Location = new System.Drawing.Point(416, 405);
        this.btnRefresh.Name = "btnRefresh";
        this.btnRefresh.Size = new System.Drawing.Size(80, 28);
        this.btnRefresh.TabIndex = 1;
        this.btnRefresh.Text = "Refresh";
        this.btnRefresh.UseVisualStyleBackColor = true;
        this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
        // 
        // btnClose
        // 
        this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
        this.btnClose.Location = new System.Drawing.Point(592, 405);
        this.btnClose.Name = "btnClose";
        this.btnClose.Size = new System.Drawing.Size(80, 28);
        this.btnClose.TabIndex = 2;
        this.btnClose.Text = "Close";
        this.btnClose.UseVisualStyleBackColor = true;
        this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
        // 
        // btnOpenFolder
        // 
        this.btnOpenFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
        this.btnOpenFolder.Location = new System.Drawing.Point(502, 405);
        this.btnOpenFolder.Name = "btnOpenFolder";
        this.btnOpenFolder.Size = new System.Drawing.Size(84, 28);
        this.btnOpenFolder.TabIndex = 3;
        this.btnOpenFolder.Text = "Open Folder";
        this.btnOpenFolder.UseVisualStyleBackColor = true;
        this.btnOpenFolder.Click += new System.EventHandler(this.btnOpenFolder_Click);
        // 
        // LogViewerForm
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(684, 441);
        this.Controls.Add(this.btnOpenFolder);
        this.Controls.Add(this.btnClose);
        this.Controls.Add(this.btnRefresh);
        this.Controls.Add(this.txtLog);
        this.MinimizeBox = false;
        this.MinimumSize = new System.Drawing.Size(500, 300);
        this.Name = "LogViewerForm";
        this.ShowIcon = false;
        this.ShowInTaskbar = false;
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
        this.Text = "Log Viewer - Today's Log";
        this.Load += new System.EventHandler(this.LogViewerForm_Load);
        this.ResumeLayout(false);
        this.PerformLayout();
    }

    #endregion

    private System.Windows.Forms.TextBox txtLog;
    private System.Windows.Forms.Button btnRefresh;
    private System.Windows.Forms.Button btnClose;
    private System.Windows.Forms.Button btnOpenFolder;
}
