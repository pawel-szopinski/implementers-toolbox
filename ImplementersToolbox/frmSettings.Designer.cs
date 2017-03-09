namespace ImplementersToolbox
{
    partial class frmSettings
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtWinFiles = new System.Windows.Forms.TextBox();
            this.txtOriginalFiles = new System.Windows.Forms.TextBox();
            this.txtSendKeyDelay = new System.Windows.Forms.TextBox();
            this.rtxtApps = new System.Windows.Forms.RichTextBox();
            this.rtxtKeyCombinations = new System.Windows.Forms.RichTextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.gbAppAutomation = new System.Windows.Forms.GroupBox();
            this.lblKeyCombinations = new System.Windows.Forms.Label();
            this.lblApp = new System.Windows.Forms.Label();
            this.lblSendKeyDelay = new System.Windows.Forms.Label();
            this.lblWinFiles = new System.Windows.Forms.Label();
            this.gbCompareReports = new System.Windows.Forms.GroupBox();
            this.lblAdditionalColumns = new System.Windows.Forms.Label();
            this.clbAdditionalColumns = new System.Windows.Forms.CheckedListBox();
            this.lblOriginalFiles = new System.Windows.Forms.Label();
            this.clbOtherSettings = new System.Windows.Forms.CheckedListBox();
            this.lblOtherSettings = new System.Windows.Forms.Label();
            this.gbAppAutomation.SuspendLayout();
            this.gbCompareReports.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(277, 524);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtWinFiles
            // 
            this.txtWinFiles.Location = new System.Drawing.Point(6, 32);
            this.txtWinFiles.Name = "txtWinFiles";
            this.txtWinFiles.Size = new System.Drawing.Size(420, 20);
            this.txtWinFiles.TabIndex = 1;
            // 
            // txtOriginalFiles
            // 
            this.txtOriginalFiles.Location = new System.Drawing.Point(6, 80);
            this.txtOriginalFiles.Name = "txtOriginalFiles";
            this.txtOriginalFiles.Size = new System.Drawing.Size(420, 20);
            this.txtOriginalFiles.TabIndex = 3;
            // 
            // txtSendKeyDelay
            // 
            this.txtSendKeyDelay.Location = new System.Drawing.Point(98, 19);
            this.txtSendKeyDelay.MaxLength = 4;
            this.txtSendKeyDelay.Name = "txtSendKeyDelay";
            this.txtSendKeyDelay.Size = new System.Drawing.Size(100, 20);
            this.txtSendKeyDelay.TabIndex = 1;
            // 
            // rtxtApps
            // 
            this.rtxtApps.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtxtApps.Location = new System.Drawing.Point(6, 67);
            this.rtxtApps.Name = "rtxtApps";
            this.rtxtApps.Size = new System.Drawing.Size(420, 96);
            this.rtxtApps.TabIndex = 3;
            this.rtxtApps.Text = "";
            // 
            // rtxtKeyCombinations
            // 
            this.rtxtKeyCombinations.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtxtKeyCombinations.Location = new System.Drawing.Point(6, 191);
            this.rtxtKeyCombinations.Name = "rtxtKeyCombinations";
            this.rtxtKeyCombinations.Size = new System.Drawing.Size(420, 96);
            this.rtxtKeyCombinations.TabIndex = 5;
            this.rtxtKeyCombinations.Text = "";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(369, 524);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(12, 524);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 2;
            this.btnReset.Text = "Reset All";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // gbAppAutomation
            // 
            this.gbAppAutomation.Controls.Add(this.lblKeyCombinations);
            this.gbAppAutomation.Controls.Add(this.lblApp);
            this.gbAppAutomation.Controls.Add(this.lblSendKeyDelay);
            this.gbAppAutomation.Controls.Add(this.txtSendKeyDelay);
            this.gbAppAutomation.Controls.Add(this.rtxtApps);
            this.gbAppAutomation.Controls.Add(this.rtxtKeyCombinations);
            this.gbAppAutomation.Location = new System.Drawing.Point(12, 214);
            this.gbAppAutomation.Name = "gbAppAutomation";
            this.gbAppAutomation.Size = new System.Drawing.Size(432, 293);
            this.gbAppAutomation.TabIndex = 1;
            this.gbAppAutomation.TabStop = false;
            this.gbAppAutomation.Text = "Application Automation";
            // 
            // lblKeyCombinations
            // 
            this.lblKeyCombinations.AutoSize = true;
            this.lblKeyCombinations.Location = new System.Drawing.Point(3, 175);
            this.lblKeyCombinations.Name = "lblKeyCombinations";
            this.lblKeyCombinations.Size = new System.Drawing.Size(94, 13);
            this.lblKeyCombinations.TabIndex = 4;
            this.lblKeyCombinations.Text = "Key Combinations:";
            // 
            // lblApp
            // 
            this.lblApp.AutoSize = true;
            this.lblApp.Location = new System.Drawing.Point(6, 51);
            this.lblApp.Name = "lblApp";
            this.lblApp.Size = new System.Drawing.Size(98, 13);
            this.lblApp.TabIndex = 2;
            this.lblApp.Text = "Application Names:";
            // 
            // lblSendKeyDelay
            // 
            this.lblSendKeyDelay.AutoSize = true;
            this.lblSendKeyDelay.Location = new System.Drawing.Point(6, 19);
            this.lblSendKeyDelay.Name = "lblSendKeyDelay";
            this.lblSendKeyDelay.Size = new System.Drawing.Size(86, 13);
            this.lblSendKeyDelay.TabIndex = 0;
            this.lblSendKeyDelay.Text = "Send Key Delay:";
            // 
            // lblWinFiles
            // 
            this.lblWinFiles.Location = new System.Drawing.Point(6, 16);
            this.lblWinFiles.Name = "lblWinFiles";
            this.lblWinFiles.Size = new System.Drawing.Size(94, 13);
            this.lblWinFiles.TabIndex = 0;
            this.lblWinFiles.Text = "WIN Files:";
            // 
            // gbCompareReports
            // 
            this.gbCompareReports.Controls.Add(this.lblOtherSettings);
            this.gbCompareReports.Controls.Add(this.lblAdditionalColumns);
            this.gbCompareReports.Controls.Add(this.clbOtherSettings);
            this.gbCompareReports.Controls.Add(this.clbAdditionalColumns);
            this.gbCompareReports.Controls.Add(this.lblOriginalFiles);
            this.gbCompareReports.Controls.Add(this.txtWinFiles);
            this.gbCompareReports.Controls.Add(this.lblWinFiles);
            this.gbCompareReports.Controls.Add(this.txtOriginalFiles);
            this.gbCompareReports.Location = new System.Drawing.Point(12, 12);
            this.gbCompareReports.Name = "gbCompareReports";
            this.gbCompareReports.Size = new System.Drawing.Size(432, 184);
            this.gbCompareReports.TabIndex = 0;
            this.gbCompareReports.TabStop = false;
            this.gbCompareReports.Text = "Compare Reports";
            // 
            // lblAdditionalColumns
            // 
            this.lblAdditionalColumns.Location = new System.Drawing.Point(6, 113);
            this.lblAdditionalColumns.Name = "lblAdditionalColumns";
            this.lblAdditionalColumns.Size = new System.Drawing.Size(115, 13);
            this.lblAdditionalColumns.TabIndex = 4;
            this.lblAdditionalColumns.Text = "Additional Columns:";
            // 
            // clbAdditionalColumns
            // 
            this.clbAdditionalColumns.FormattingEnabled = true;
            this.clbAdditionalColumns.Items.AddRange(new object[] {
            "File Extension",
            "WIN File Full Path",
            "Original File Full Path"});
            this.clbAdditionalColumns.Location = new System.Drawing.Point(6, 129);
            this.clbAdditionalColumns.Name = "clbAdditionalColumns";
            this.clbAdditionalColumns.Size = new System.Drawing.Size(130, 49);
            this.clbAdditionalColumns.TabIndex = 5;
            // 
            // lblOriginalFiles
            // 
            this.lblOriginalFiles.Location = new System.Drawing.Point(6, 64);
            this.lblOriginalFiles.Name = "lblOriginalFiles";
            this.lblOriginalFiles.Size = new System.Drawing.Size(94, 13);
            this.lblOriginalFiles.TabIndex = 2;
            this.lblOriginalFiles.Text = "Original Files:";
            // 
            // clbOtherSettings
            // 
            this.clbOtherSettings.FormattingEnabled = true;
            this.clbOtherSettings.Items.AddRange(new object[] {
            "Ignore System Files"});
            this.clbOtherSettings.Location = new System.Drawing.Point(142, 129);
            this.clbOtherSettings.Name = "clbOtherSettings";
            this.clbOtherSettings.Size = new System.Drawing.Size(130, 49);
            this.clbOtherSettings.TabIndex = 7;
            // 
            // lblOtherSettings
            // 
            this.lblOtherSettings.Location = new System.Drawing.Point(142, 113);
            this.lblOtherSettings.Name = "lblOtherSettings";
            this.lblOtherSettings.Size = new System.Drawing.Size(92, 13);
            this.lblOtherSettings.TabIndex = 6;
            this.lblOtherSettings.Text = "Other Settings:";
            // 
            // frmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 558);
            this.Controls.Add(this.gbCompareReports);
            this.Controls.Add(this.gbAppAutomation);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSettings";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Advanced Settings";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmSettings_FormClosing);
            this.Load += new System.EventHandler(this.frmSettings_Load);
            this.gbAppAutomation.ResumeLayout(false);
            this.gbAppAutomation.PerformLayout();
            this.gbCompareReports.ResumeLayout(false);
            this.gbCompareReports.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtWinFiles;
        private System.Windows.Forms.TextBox txtOriginalFiles;
        private System.Windows.Forms.TextBox txtSendKeyDelay;
        private System.Windows.Forms.RichTextBox rtxtApps;
        private System.Windows.Forms.RichTextBox rtxtKeyCombinations;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.GroupBox gbAppAutomation;
        private System.Windows.Forms.Label lblSendKeyDelay;
        private System.Windows.Forms.Label lblKeyCombinations;
        private System.Windows.Forms.Label lblApp;
        private System.Windows.Forms.Label lblWinFiles;
        private System.Windows.Forms.GroupBox gbCompareReports;
        private System.Windows.Forms.CheckedListBox clbAdditionalColumns;
        private System.Windows.Forms.Label lblOriginalFiles;
        private System.Windows.Forms.Label lblAdditionalColumns;
        private System.Windows.Forms.Label lblOtherSettings;
        private System.Windows.Forms.CheckedListBox clbOtherSettings;
    }
}