namespace IisExpressLauncher
{
    partial class Main
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
            this.tbxWebSiteDir = new System.Windows.Forms.TextBox();
            this.tbxPortNo = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnSelectDir = new System.Windows.Forms.Button();
            this.lblPortNo = new System.Windows.Forms.Label();
            this.lblWebsiteDir = new System.Windows.Forms.Label();
            this.lblFeedback = new System.Windows.Forms.Label();
            this.cbxOpenInBrowser = new System.Windows.Forms.CheckBox();
            this.pnlSetIisExpressPath = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnChoosePathToIisExpress = new System.Windows.Forms.Button();
            this.tbxPathToIisExpress = new System.Windows.Forms.TextBox();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlSetIisExpressPath.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbxWebSiteDir
            // 
            this.tbxWebSiteDir.Location = new System.Drawing.Point(16, 45);
            this.tbxWebSiteDir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbxWebSiteDir.Name = "tbxWebSiteDir";
            this.tbxWebSiteDir.Size = new System.Drawing.Size(357, 26);
            this.tbxWebSiteDir.TabIndex = 0;
            // 
            // tbxPortNo
            // 
            this.tbxPortNo.Location = new System.Drawing.Point(18, 118);
            this.tbxPortNo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbxPortNo.Name = "tbxPortNo";
            this.tbxPortNo.Size = new System.Drawing.Size(134, 26);
            this.tbxPortNo.TabIndex = 1;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(18, 176);
            this.btnStart.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(112, 35);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Start Server";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnSelectDir
            // 
            this.btnSelectDir.Location = new System.Drawing.Point(381, 41);
            this.btnSelectDir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSelectDir.Name = "btnSelectDir";
            this.btnSelectDir.Size = new System.Drawing.Size(105, 35);
            this.btnSelectDir.TabIndex = 3;
            this.btnSelectDir.Text = "Choose...";
            this.btnSelectDir.UseVisualStyleBackColor = true;
            this.btnSelectDir.Click += new System.EventHandler(this.btnSelectDir_Click);
            // 
            // lblPortNo
            // 
            this.lblPortNo.AutoSize = true;
            this.lblPortNo.Location = new System.Drawing.Point(12, 94);
            this.lblPortNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPortNo.Name = "lblPortNo";
            this.lblPortNo.Size = new System.Drawing.Size(102, 20);
            this.lblPortNo.TabIndex = 4;
            this.lblPortNo.Text = "Port Number:";
            // 
            // lblWebsiteDir
            // 
            this.lblWebsiteDir.AutoSize = true;
            this.lblWebsiteDir.Location = new System.Drawing.Point(13, 17);
            this.lblWebsiteDir.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWebsiteDir.Name = "lblWebsiteDir";
            this.lblWebsiteDir.Size = new System.Drawing.Size(108, 20);
            this.lblWebsiteDir.TabIndex = 5;
            this.lblWebsiteDir.Text = "Website Path:";
            // 
            // lblFeedback
            // 
            this.lblFeedback.AutoSize = true;
            this.lblFeedback.ForeColor = System.Drawing.Color.Red;
            this.lblFeedback.Location = new System.Drawing.Point(14, 25);
            this.lblFeedback.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFeedback.MaximumSize = new System.Drawing.Size(464, 500);
            this.lblFeedback.Name = "lblFeedback";
            this.lblFeedback.Size = new System.Drawing.Size(95, 20);
            this.lblFeedback.TabIndex = 6;
            this.lblFeedback.Text = "lblFeedback";
            // 
            // cbxOpenInBrowser
            // 
            this.cbxOpenInBrowser.AutoSize = true;
            this.cbxOpenInBrowser.Location = new System.Drawing.Point(155, 184);
            this.cbxOpenInBrowser.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbxOpenInBrowser.Name = "cbxOpenInBrowser";
            this.cbxOpenInBrowser.Size = new System.Drawing.Size(154, 24);
            this.cbxOpenInBrowser.TabIndex = 7;
            this.cbxOpenInBrowser.Text = "Open In Browser";
            this.cbxOpenInBrowser.UseVisualStyleBackColor = true;
            // 
            // pnlSetIisExpressPath
            // 
            this.pnlSetIisExpressPath.Controls.Add(this.btnSave);
            this.pnlSetIisExpressPath.Controls.Add(this.label1);
            this.pnlSetIisExpressPath.Controls.Add(this.btnChoosePathToIisExpress);
            this.pnlSetIisExpressPath.Controls.Add(this.tbxPathToIisExpress);
            this.pnlSetIisExpressPath.Location = new System.Drawing.Point(0, 317);
            this.pnlSetIisExpressPath.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlSetIisExpressPath.Name = "pnlSetIisExpressPath";
            this.pnlSetIisExpressPath.Size = new System.Drawing.Size(500, 180);
            this.pnlSetIisExpressPath.TabIndex = 8;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(24, 115);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(105, 35);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Path to iisexpress.exe:";
            // 
            // btnChoosePathToIisExpress
            // 
            this.btnChoosePathToIisExpress.Location = new System.Drawing.Point(381, 51);
            this.btnChoosePathToIisExpress.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnChoosePathToIisExpress.Name = "btnChoosePathToIisExpress";
            this.btnChoosePathToIisExpress.Size = new System.Drawing.Size(105, 35);
            this.btnChoosePathToIisExpress.TabIndex = 7;
            this.btnChoosePathToIisExpress.Text = "Choose...";
            this.btnChoosePathToIisExpress.UseVisualStyleBackColor = true;
            this.btnChoosePathToIisExpress.Click += new System.EventHandler(this.btnChoosePathToIisExpress_Click);
            // 
            // tbxPathToIisExpress
            // 
            this.tbxPathToIisExpress.Location = new System.Drawing.Point(24, 55);
            this.tbxPathToIisExpress.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbxPathToIisExpress.Name = "tbxPathToIisExpress";
            this.tbxPathToIisExpress.Size = new System.Drawing.Size(349, 26);
            this.tbxPathToIisExpress.TabIndex = 6;
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.lblWebsiteDir);
            this.pnlMain.Controls.Add(this.tbxWebSiteDir);
            this.pnlMain.Controls.Add(this.cbxOpenInBrowser);
            this.pnlMain.Controls.Add(this.tbxPortNo);
            this.pnlMain.Controls.Add(this.btnStart);
            this.pnlMain.Controls.Add(this.btnSelectDir);
            this.pnlMain.Controls.Add(this.lblPortNo);
            this.pnlMain.Location = new System.Drawing.Point(0, 50);
            this.pnlMain.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(500, 232);
            this.pnlMain.TabIndex = 9;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 544);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlSetIisExpressPath);
            this.Controls.Add(this.lblFeedback);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Main";
            this.Text = "IIS Express Launcher";
            this.pnlSetIisExpressPath.ResumeLayout(false);
            this.pnlSetIisExpressPath.PerformLayout();
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxWebSiteDir;
        private System.Windows.Forms.TextBox tbxPortNo;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnSelectDir;
        private System.Windows.Forms.Label lblPortNo;
        private System.Windows.Forms.Label lblWebsiteDir;
        private System.Windows.Forms.Label lblFeedback;
        private System.Windows.Forms.CheckBox cbxOpenInBrowser;
        private System.Windows.Forms.Panel pnlSetIisExpressPath;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnChoosePathToIisExpress;
        private System.Windows.Forms.TextBox tbxPathToIisExpress;
        private System.Windows.Forms.Panel pnlMain;
    }
}

