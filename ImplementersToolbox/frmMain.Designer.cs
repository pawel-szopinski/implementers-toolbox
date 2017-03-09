namespace ImplementersToolbox
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            this.tcMain = new System.Windows.Forms.TabControl();
            this.tabWelcome = new System.Windows.Forms.TabPage();
            this.pbEmblem = new System.Windows.Forms.PictureBox();
            this.tabCompareReports = new System.Windows.Forms.TabPage();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnOpenOriginal = new System.Windows.Forms.Button();
            this.btnOpenWinFiles = new System.Windows.Forms.Button();
            this.gbCompareMethod = new System.Windows.Forms.GroupBox();
            this.rbBinary = new System.Windows.Forms.RadioButton();
            this.rbModDate = new System.Windows.Forms.RadioButton();
            this.btnGetData = new System.Windows.Forms.Button();
            this.lblOriginalFiles = new System.Windows.Forms.Label();
            this.lblWinFiles = new System.Windows.Forms.Label();
            this.txtWinFiles = new System.Windows.Forms.TextBox();
            this.txtOriginalFiles = new System.Windows.Forms.TextBox();
            this.btnOriginal = new System.Windows.Forms.Button();
            this.btnWinFiles = new System.Windows.Forms.Button();
            this.dgvFiles = new System.Windows.Forms.DataGridView();
            this.tabAppAutomation = new System.Windows.Forms.TabPage();
            this.cboKeyCombo = new System.Windows.Forms.ComboBox();
            this.lblApp = new System.Windows.Forms.Label();
            this.cboApp = new System.Windows.Forms.ComboBox();
            this.lblIterations = new System.Windows.Forms.Label();
            this.lblKeyCombination = new System.Windows.Forms.Label();
            this.txtIterations = new System.Windows.Forms.TextBox();
            this.btnGo = new System.Windows.Forms.Button();
            this.cmOpenFile = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmiOpenWINFile = new System.Windows.Forms.ToolStripMenuItem();
            this.cmiOpenOriginalFile = new System.Windows.Forms.ToolStripMenuItem();
            this.msMain = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.advancedSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ssMain = new System.Windows.Forms.StatusStrip();
            this.pbMain = new System.Windows.Forms.ToolStripProgressBar();
            this.sslblMain = new System.Windows.Forms.ToolStripStatusLabel();
            this.tcMain.SuspendLayout();
            this.tabWelcome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbEmblem)).BeginInit();
            this.tabCompareReports.SuspendLayout();
            this.gbCompareMethod.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFiles)).BeginInit();
            this.tabAppAutomation.SuspendLayout();
            this.cmOpenFile.SuspendLayout();
            this.msMain.SuspendLayout();
            this.ssMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcMain
            // 
            this.tcMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tcMain.Controls.Add(this.tabWelcome);
            this.tcMain.Controls.Add(this.tabCompareReports);
            this.tcMain.Controls.Add(this.tabAppAutomation);
            this.tcMain.Location = new System.Drawing.Point(12, 27);
            this.tcMain.Name = "tcMain";
            this.tcMain.SelectedIndex = 0;
            this.tcMain.Size = new System.Drawing.Size(915, 576);
            this.tcMain.TabIndex = 1;
            // 
            // tabWelcome
            // 
            this.tabWelcome.BackColor = System.Drawing.Color.Gainsboro;
            this.tabWelcome.Controls.Add(this.pbEmblem);
            this.tabWelcome.Location = new System.Drawing.Point(4, 22);
            this.tabWelcome.Name = "tabWelcome";
            this.tabWelcome.Padding = new System.Windows.Forms.Padding(3);
            this.tabWelcome.Size = new System.Drawing.Size(907, 550);
            this.tabWelcome.TabIndex = 0;
            this.tabWelcome.Text = "Welcome";
            // 
            // pbEmblem
            // 
            this.pbEmblem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbEmblem.Image = global::ImplementersToolbox.Properties.Resources.emblem;
            this.pbEmblem.Location = new System.Drawing.Point(97, 51);
            this.pbEmblem.Name = "pbEmblem";
            this.pbEmblem.Size = new System.Drawing.Size(713, 448);
            this.pbEmblem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbEmblem.TabIndex = 0;
            this.pbEmblem.TabStop = false;
            // 
            // tabCompareReports
            // 
            this.tabCompareReports.Controls.Add(this.btnExport);
            this.tabCompareReports.Controls.Add(this.btnOpenOriginal);
            this.tabCompareReports.Controls.Add(this.btnOpenWinFiles);
            this.tabCompareReports.Controls.Add(this.gbCompareMethod);
            this.tabCompareReports.Controls.Add(this.btnGetData);
            this.tabCompareReports.Controls.Add(this.lblOriginalFiles);
            this.tabCompareReports.Controls.Add(this.lblWinFiles);
            this.tabCompareReports.Controls.Add(this.txtWinFiles);
            this.tabCompareReports.Controls.Add(this.txtOriginalFiles);
            this.tabCompareReports.Controls.Add(this.btnOriginal);
            this.tabCompareReports.Controls.Add(this.btnWinFiles);
            this.tabCompareReports.Controls.Add(this.dgvFiles);
            this.tabCompareReports.Location = new System.Drawing.Point(4, 22);
            this.tabCompareReports.Name = "tabCompareReports";
            this.tabCompareReports.Padding = new System.Windows.Forms.Padding(3);
            this.tabCompareReports.Size = new System.Drawing.Size(907, 550);
            this.tabCompareReports.TabIndex = 1;
            this.tabCompareReports.Text = "Compare Reports";
            this.tabCompareReports.UseVisualStyleBackColor = true;
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(628, 85);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(75, 22);
            this.btnExport.TabIndex = 9;
            this.btnExport.Tag = "disable";
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnOpenOriginal
            // 
            this.btnOpenOriginal.Location = new System.Drawing.Point(628, 37);
            this.btnOpenOriginal.Name = "btnOpenOriginal";
            this.btnOpenOriginal.Size = new System.Drawing.Size(75, 22);
            this.btnOpenOriginal.TabIndex = 7;
            this.btnOpenOriginal.Text = "Open...";
            this.btnOpenOriginal.UseVisualStyleBackColor = true;
            this.btnOpenOriginal.Click += new System.EventHandler(this.btnOpenOriginal_Click);
            // 
            // btnOpenWinFiles
            // 
            this.btnOpenWinFiles.Location = new System.Drawing.Point(628, 5);
            this.btnOpenWinFiles.Name = "btnOpenWinFiles";
            this.btnOpenWinFiles.Size = new System.Drawing.Size(75, 22);
            this.btnOpenWinFiles.TabIndex = 3;
            this.btnOpenWinFiles.Text = "Open...";
            this.btnOpenWinFiles.UseVisualStyleBackColor = true;
            this.btnOpenWinFiles.Click += new System.EventHandler(this.btnOpenWinFiles_Click);
            // 
            // gbCompareMethod
            // 
            this.gbCompareMethod.Controls.Add(this.rbBinary);
            this.gbCompareMethod.Controls.Add(this.rbModDate);
            this.gbCompareMethod.Location = new System.Drawing.Point(750, 6);
            this.gbCompareMethod.Name = "gbCompareMethod";
            this.gbCompareMethod.Size = new System.Drawing.Size(126, 100);
            this.gbCompareMethod.TabIndex = 10;
            this.gbCompareMethod.TabStop = false;
            this.gbCompareMethod.Tag = "";
            this.gbCompareMethod.Text = "Compare Method";
            // 
            // rbBinary
            // 
            this.rbBinary.AutoSize = true;
            this.rbBinary.Checked = true;
            this.rbBinary.Location = new System.Drawing.Point(6, 34);
            this.rbBinary.Name = "rbBinary";
            this.rbBinary.Size = new System.Drawing.Size(54, 17);
            this.rbBinary.TabIndex = 0;
            this.rbBinary.TabStop = true;
            this.rbBinary.Tag = "";
            this.rbBinary.Text = "Binary";
            this.rbBinary.UseVisualStyleBackColor = true;
            // 
            // rbModDate
            // 
            this.rbModDate.AutoSize = true;
            this.rbModDate.Location = new System.Drawing.Point(6, 58);
            this.rbModDate.Name = "rbModDate";
            this.rbModDate.Size = new System.Drawing.Size(114, 17);
            this.rbModDate.TabIndex = 1;
            this.rbModDate.Tag = "";
            this.rbModDate.Text = "Last Modified Date";
            this.rbModDate.UseVisualStyleBackColor = true;
            // 
            // btnGetData
            // 
            this.btnGetData.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnGetData.Location = new System.Drawing.Point(121, 85);
            this.btnGetData.Name = "btnGetData";
            this.btnGetData.Size = new System.Drawing.Size(420, 37);
            this.btnGetData.TabIndex = 8;
            this.btnGetData.Tag = "disable";
            this.btnGetData.Text = "Get Data";
            this.btnGetData.UseVisualStyleBackColor = true;
            this.btnGetData.Click += new System.EventHandler(this.btnGetData_Click);
            // 
            // lblOriginalFiles
            // 
            this.lblOriginalFiles.Location = new System.Drawing.Point(6, 38);
            this.lblOriginalFiles.Name = "lblOriginalFiles";
            this.lblOriginalFiles.Size = new System.Drawing.Size(109, 20);
            this.lblOriginalFiles.TabIndex = 4;
            this.lblOriginalFiles.Text = "Original Files:";
            // 
            // lblWinFiles
            // 
            this.lblWinFiles.Location = new System.Drawing.Point(6, 6);
            this.lblWinFiles.Name = "lblWinFiles";
            this.lblWinFiles.Size = new System.Drawing.Size(109, 20);
            this.lblWinFiles.TabIndex = 0;
            this.lblWinFiles.Text = "WIN Files:";
            // 
            // txtWinFiles
            // 
            this.txtWinFiles.Location = new System.Drawing.Point(121, 6);
            this.txtWinFiles.Name = "txtWinFiles";
            this.txtWinFiles.Size = new System.Drawing.Size(420, 20);
            this.txtWinFiles.TabIndex = 1;
            // 
            // txtOriginalFiles
            // 
            this.txtOriginalFiles.Location = new System.Drawing.Point(121, 38);
            this.txtOriginalFiles.Name = "txtOriginalFiles";
            this.txtOriginalFiles.Size = new System.Drawing.Size(420, 20);
            this.txtOriginalFiles.TabIndex = 5;
            // 
            // btnOriginal
            // 
            this.btnOriginal.Location = new System.Drawing.Point(547, 37);
            this.btnOriginal.Name = "btnOriginal";
            this.btnOriginal.Size = new System.Drawing.Size(75, 22);
            this.btnOriginal.TabIndex = 6;
            this.btnOriginal.Text = "Browse...";
            this.btnOriginal.UseVisualStyleBackColor = true;
            this.btnOriginal.Click += new System.EventHandler(this.btnOriginalFiles_Click);
            // 
            // btnWinFiles
            // 
            this.btnWinFiles.Location = new System.Drawing.Point(547, 5);
            this.btnWinFiles.Name = "btnWinFiles";
            this.btnWinFiles.Size = new System.Drawing.Size(75, 22);
            this.btnWinFiles.TabIndex = 2;
            this.btnWinFiles.Text = "Browse...";
            this.btnWinFiles.UseVisualStyleBackColor = true;
            this.btnWinFiles.Click += new System.EventHandler(this.btnWinFiles_Click);
            // 
            // dgvFiles
            // 
            this.dgvFiles.AllowUserToAddRows = false;
            this.dgvFiles.AllowUserToDeleteRows = false;
            this.dgvFiles.AllowUserToOrderColumns = true;
            this.dgvFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvFiles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvFiles.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvFiles.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            this.dgvFiles.ColumnHeadersHeight = 21;
            this.dgvFiles.Location = new System.Drawing.Point(6, 141);
            this.dgvFiles.Name = "dgvFiles";
            this.dgvFiles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFiles.Size = new System.Drawing.Size(895, 403);
            this.dgvFiles.TabIndex = 11;
            this.dgvFiles.CellContextMenuStripNeeded += new System.Windows.Forms.DataGridViewCellContextMenuStripNeededEventHandler(this.dgvFiles_CellContextMenuStripNeeded);
            this.dgvFiles.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvFiles_DataBindingComplete);
            // 
            // tabAppAutomation
            // 
            this.tabAppAutomation.Controls.Add(this.cboKeyCombo);
            this.tabAppAutomation.Controls.Add(this.lblApp);
            this.tabAppAutomation.Controls.Add(this.cboApp);
            this.tabAppAutomation.Controls.Add(this.lblIterations);
            this.tabAppAutomation.Controls.Add(this.lblKeyCombination);
            this.tabAppAutomation.Controls.Add(this.txtIterations);
            this.tabAppAutomation.Controls.Add(this.btnGo);
            this.tabAppAutomation.Location = new System.Drawing.Point(4, 22);
            this.tabAppAutomation.Name = "tabAppAutomation";
            this.tabAppAutomation.Padding = new System.Windows.Forms.Padding(3);
            this.tabAppAutomation.Size = new System.Drawing.Size(907, 550);
            this.tabAppAutomation.TabIndex = 2;
            this.tabAppAutomation.Text = "Application Automation";
            this.tabAppAutomation.UseVisualStyleBackColor = true;
            // 
            // cboKeyCombo
            // 
            this.cboKeyCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboKeyCombo.FormattingEnabled = true;
            this.cboKeyCombo.Location = new System.Drawing.Point(121, 35);
            this.cboKeyCombo.Name = "cboKeyCombo";
            this.cboKeyCombo.Size = new System.Drawing.Size(420, 21);
            this.cboKeyCombo.TabIndex = 3;
            // 
            // lblApp
            // 
            this.lblApp.Location = new System.Drawing.Point(6, 6);
            this.lblApp.Name = "lblApp";
            this.lblApp.Size = new System.Drawing.Size(109, 20);
            this.lblApp.TabIndex = 0;
            this.lblApp.Text = "Application";
            // 
            // cboApp
            // 
            this.cboApp.BackColor = System.Drawing.SystemColors.Window;
            this.cboApp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboApp.FormattingEnabled = true;
            this.cboApp.Location = new System.Drawing.Point(121, 6);
            this.cboApp.Name = "cboApp";
            this.cboApp.Size = new System.Drawing.Size(420, 21);
            this.cboApp.TabIndex = 1;
            // 
            // lblIterations
            // 
            this.lblIterations.Location = new System.Drawing.Point(6, 68);
            this.lblIterations.Name = "lblIterations";
            this.lblIterations.Size = new System.Drawing.Size(109, 20);
            this.lblIterations.TabIndex = 4;
            this.lblIterations.Text = "Iterations:";
            // 
            // lblKeyCombination
            // 
            this.lblKeyCombination.Location = new System.Drawing.Point(6, 38);
            this.lblKeyCombination.Name = "lblKeyCombination";
            this.lblKeyCombination.Size = new System.Drawing.Size(109, 20);
            this.lblKeyCombination.TabIndex = 2;
            this.lblKeyCombination.Text = "Key Combination:";
            // 
            // txtIterations
            // 
            this.txtIterations.Location = new System.Drawing.Point(121, 68);
            this.txtIterations.MaxLength = 3;
            this.txtIterations.Name = "txtIterations";
            this.txtIterations.Size = new System.Drawing.Size(100, 20);
            this.txtIterations.TabIndex = 5;
            // 
            // btnGo
            // 
            this.btnGo.AccessibleDescription = "";
            this.btnGo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnGo.Location = new System.Drawing.Point(121, 116);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(420, 37);
            this.btnGo.TabIndex = 6;
            this.btnGo.Tag = "disable";
            this.btnGo.Text = "Go";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // cmOpenFile
            // 
            this.cmOpenFile.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmiOpenWINFile,
            this.cmiOpenOriginalFile});
            this.cmOpenFile.Name = "cmOpenFile";
            this.cmOpenFile.Size = new System.Drawing.Size(170, 70);
            // 
            // cmiOpenWINFile
            // 
            this.cmiOpenWINFile.Name = "cmiOpenWINFile";
            this.cmiOpenWINFile.Size = new System.Drawing.Size(169, 22);
            this.cmiOpenWINFile.Text = "Open WIN File";
            this.cmiOpenWINFile.Click += new System.EventHandler(this.cmiOpenWINFile_Click);
            // 
            // cmiOpenOriginalFile
            // 
            this.cmiOpenOriginalFile.Name = "cmiOpenOriginalFile";
            this.cmiOpenOriginalFile.Size = new System.Drawing.Size(169, 22);
            this.cmiOpenOriginalFile.Text = "Open Original File";
            this.cmiOpenOriginalFile.Click += new System.EventHandler(this.cmiOpenOriginalFile_Click);
            // 
            // msMain
            // 
            this.msMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.msMain.Location = new System.Drawing.Point(0, 0);
            this.msMain.Name = "msMain";
            this.msMain.Size = new System.Drawing.Size(939, 24);
            this.msMain.TabIndex = 0;
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.advancedSettingsToolStripMenuItem,
            this.tsSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // advancedSettingsToolStripMenuItem
            // 
            this.advancedSettingsToolStripMenuItem.Name = "advancedSettingsToolStripMenuItem";
            this.advancedSettingsToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.advancedSettingsToolStripMenuItem.Text = "&Advanced Settings";
            this.advancedSettingsToolStripMenuItem.Click += new System.EventHandler(this.advancedSettingsToolStripMenuItem_Click);
            // 
            // tsSeparator1
            // 
            this.tsSeparator1.Name = "tsSeparator1";
            this.tsSeparator1.Size = new System.Drawing.Size(169, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.exitToolStripMenuItem.Text = "&Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // ssMain
            // 
            this.ssMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pbMain,
            this.sslblMain});
            this.ssMain.Location = new System.Drawing.Point(0, 606);
            this.ssMain.Name = "ssMain";
            this.ssMain.Size = new System.Drawing.Size(939, 22);
            this.ssMain.TabIndex = 2;
            // 
            // pbMain
            // 
            this.pbMain.Name = "pbMain";
            this.pbMain.Size = new System.Drawing.Size(200, 16);
            this.pbMain.Step = 1;
            // 
            // sslblMain
            // 
            this.sslblMain.Name = "sslblMain";
            this.sslblMain.Size = new System.Drawing.Size(48, 17);
            this.sslblMain.Text = "Ready...";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 628);
            this.Controls.Add(this.ssMain);
            this.Controls.Add(this.tcMain);
            this.Controls.Add(this.msMain);
            this.Icon = global::ImplementersToolbox.Properties.Resources.MainIcon;
            this.MainMenuStrip = this.msMain;
            this.Name = "frmMain";
            this.Text = "Implementer\'s Toolbox";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.tcMain.ResumeLayout(false);
            this.tabWelcome.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbEmblem)).EndInit();
            this.tabCompareReports.ResumeLayout(false);
            this.tabCompareReports.PerformLayout();
            this.gbCompareMethod.ResumeLayout(false);
            this.gbCompareMethod.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFiles)).EndInit();
            this.tabAppAutomation.ResumeLayout(false);
            this.tabAppAutomation.PerformLayout();
            this.cmOpenFile.ResumeLayout(false);
            this.msMain.ResumeLayout(false);
            this.msMain.PerformLayout();
            this.ssMain.ResumeLayout(false);
            this.ssMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tcMain;
        private System.Windows.Forms.TabPage tabWelcome;
        private System.Windows.Forms.TabPage tabCompareReports;
        private System.Windows.Forms.MenuStrip msMain;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem advancedSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.StatusStrip ssMain;
        private System.Windows.Forms.ToolStripProgressBar pbMain;
        private System.Windows.Forms.ToolStripStatusLabel sslblMain;
        private System.Windows.Forms.TabPage tabAppAutomation;
        private System.Windows.Forms.PictureBox pbEmblem;
        private System.Windows.Forms.DataGridView dgvFiles;
        private System.Windows.Forms.Button btnGetData;
        private System.Windows.Forms.Label lblOriginalFiles;
        private System.Windows.Forms.Label lblWinFiles;
        private System.Windows.Forms.TextBox txtWinFiles;
        private System.Windows.Forms.TextBox txtOriginalFiles;
        private System.Windows.Forms.Button btnOriginal;
        private System.Windows.Forms.Button btnWinFiles;
        private System.Windows.Forms.RadioButton rbModDate;
        private System.Windows.Forms.RadioButton rbBinary;
        private System.Windows.Forms.GroupBox gbCompareMethod;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.Label lblKeyCombination;
        private System.Windows.Forms.TextBox txtIterations;
        private System.Windows.Forms.Label lblIterations;
        private System.Windows.Forms.Label lblApp;
        private System.Windows.Forms.ComboBox cboApp;
        private System.Windows.Forms.ComboBox cboKeyCombo;
        private System.Windows.Forms.Button btnOpenOriginal;
        private System.Windows.Forms.Button btnOpenWinFiles;
        private System.Windows.Forms.ToolStripSeparator tsSeparator1;
        private System.Windows.Forms.ContextMenuStrip cmOpenFile;
        private System.Windows.Forms.ToolStripMenuItem cmiOpenWINFile;
        private System.Windows.Forms.ToolStripMenuItem cmiOpenOriginalFile;
        private System.Windows.Forms.Button btnExport;
    }
}

