using AppAutomation;
using FileCompare;
using ImplementersToolbox.Properties;
using ImplementersToolbox.Utilities.ExportData;
using ImplementersToolbox.Utilities.FolderBrowser;
using ImplementersToolbox.Utilities.SortableList;
using Microsoft.WindowsAPICodePack.Taskbar;
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImplementersToolbox
{
    public partial class frmMain : Form
    {
        private readonly TaskbarManager tbManager = TaskbarManager.Instance;
        private string lastOriginalPath;
        private string lastWinPath;

        public frmMain()
        {
            InitializeComponent();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (frmAbout form = new frmAbout())
                form.ShowDialog(this);
        }

        private void advancedSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (frmSettings form = new frmSettings(this))
                form.ShowDialog();
        }

        private async void btnExport_Click(object sender, EventArgs e)
        {
            if (dgvFiles.DataSource != null)
            {
                ResetStatus();

                SaveFileDialog sfd = new SaveFileDialog
                {
                    Title = "Save as Excel File",
                    InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop),
                    Filter = "Excel Workbook (*.xlsx)|*.xlsx",
                    FileName = "Compare Reports - Result.xlsx"
                };

                try
                {
                    sslblMain.Text = $"[{ btnExport.Parent.Text }] Choosing save destination";

                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        EnableControlsAndManageTaskbar(false);

                        pbMain.Maximum = 3;
                        Progress<byte> progress = new Progress<byte>(action =>
                        {
                            tbManager.SetProgressValue(action, pbMain.Maximum);
                            pbMain.Value = action;
                            if (action == 1)
                                sslblMain.Text = $"[{btnExport.Parent.Text}] Opening Excel instance";
                            else
                                sslblMain.Text = $"[{btnExport.Parent.Text}] Exporting data";
                        });

                        await Task.Run(() => ExportDataGridView.ToExcel(dgvFiles, sfd.FileName, progress));

                        sslblMain.Text = $"[{btnExport.Parent.Text}] Data export completed!";
                    }
                    else
                        sslblMain.Text = $"[{btnExport.Parent.Text}] Data export cancelled...";
                }
                catch (Exception ex)
                {
                    ExceptionHandler(
                        btnExport.Parent.Text,
                        "An error occured during data export!",
                        ex.GetType().Name,
                        ex.Message,
                        ex.StackTrace);
                }
                finally
                {
                    EnableControlsAndManageTaskbar(true);
                }
            }
            else
            {
                MessageBox.Show("There is no data to export!", "Data Required", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
        }

        private async void btnGetData_Click(object sender, EventArgs e)
        {
            ResetStatus();
            dgvFiles.DataSource = null;
            dgvFiles.Rows.Clear();

            string[,] fileList;

            try
            {
                fileList = FolderPairReader.GetFiles(txtWinFiles.Text, txtOriginalFiles.Text, Settings.Default.IgnoreSystemFiles);
            }
            catch (Exception exception)
            {
                ExceptionHandler(
                    btnGetData.Parent.Text,
                    "An error occured while obtaining WIN files list!",
                    exception.GetType().Name,
                    exception.Message,
                    exception.StackTrace);
                return;
            }

            try
            {
                if (fileList == null)
                    return;

                EnableControlsAndManageTaskbar(false);

                pbMain.Maximum = fileList.Length / 2;

                CompareMethod compareMethod = rbBinary.Checked ? CompareMethod.Binary : CompareMethod.ModifyDate;

                Progress<int> progress = new Progress<int>(fileNumber =>
                {
                    pbMain.Value = fileNumber;
                    tbManager.SetProgressValue(fileNumber, pbMain.Maximum);
                    sslblMain.Text = $"[{btnGetData.Parent.Text}] Reading file set {fileNumber} of {pbMain.Maximum}";
                });

                await Task.Run(() => ReadResultsList.Generate(fileList, compareMethod, progress)).ContinueWith(t =>
                {
                    SortableBindingList<ReportPair> sbl = new SortableBindingList<ReportPair>(t.Result);
                    dgvFiles.DataSource = sbl;
                },
                    TaskScheduler.FromCurrentSynchronizationContext());

                sslblMain.Text = $"[{btnGetData.Parent.Text}] Finished - {dgvFiles.RowCount} file(s) processed!";
            }
            catch (Exception ex)
            {
                ExceptionHandler(
                    btnGetData.Parent.Text,
                    "An error occured while processing your request!",
                    ex.GetType().Name,
                    ex.Message,
                    ex.StackTrace);
            }
            finally
            {
                EnableControlsAndManageTaskbar(true);
            }
        }

        private async void btnGo_Click(object sender, EventArgs e)
        {
            try
            {
                ResetStatus();

                ushort iterations;

                if (!ushort.TryParse(txtIterations.Text, out iterations))
                {
                    MessageBox.Show("Please provide a positive integer in Iterations textbox!", "Conversion Issue",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                sslblMain.Text = $"[{btnGo.Parent.Text}] Waiting for application window to be activated";

                EnableControlsAndManageTaskbar(false);

                string keyCombination = cboKeyCombo.SelectedItem.ToString();
                string remove = keyCombination.Substring(0, keyCombination.IndexOf("{", StringComparison.Ordinal));
                if (remove != string.Empty)
                    keyCombination = keyCombination.Replace(remove, string.Empty);

                string app = cboApp.SelectedItem.ToString();

                pbMain.Maximum = iterations;
                Progress<int> progress = new Progress<int>(iteration =>
                {
                    tbManager.SetProgressValue(iteration, iterations);
                    pbMain.Value = iteration;
                    sslblMain.Text = $"[{btnGo.Parent.Text}] Iteration {iteration} of {iterations}";
                });

                await Task.Run(() => AutoImplementer.SendKeys(iterations, keyCombination,
                    app, progress, Settings.Default.SendKeyDelay))
                    .ContinueWith(t =>
                    {
                        if (t.Result)
                            sslblMain.Text = $"[{btnGo.Parent.Text}] Finished - {iterations} iteration(s) processed!";
                        else
                            sslblMain.Text = $"[{btnGo.Parent.Text}] Execution stopped by user - {pbMain.Value} iteration(s) processed!";
                    },
                        TaskScheduler.FromCurrentSynchronizationContext());
            }
            catch (Exception ex)
            {
                ExceptionHandler(
                    btnGo.Parent.Text,
                    "An error occured while processing your request!",
                    ex.GetType().Name,
                    ex.Message,
                    ex.StackTrace);
            }
            finally
            {
                EnableControlsAndManageTaskbar(true);
            }
        }

        private void btnOpenOriginal_Click(object sender, EventArgs e)
        {
            OpenFolder(txtOriginalFiles.Text);
        }

        private void btnOpenWinFiles_Click(object sender, EventArgs e)
        {
            OpenFolder(txtWinFiles.Text);
        }

        private void btnOriginalFiles_Click(object sender, EventArgs e)
        {
            FolderSelectDialog fsd = new FolderSelectDialog
            {
                InitialDirectory = lastOriginalPath,
                Title = "Select Folder Containing Orignal Reports..."
            };


            if (!fsd.ShowDialog(Handle)) return;
            lastOriginalPath = fsd.FileName;
            txtOriginalFiles.Text = lastOriginalPath;
        }

        private void btnWinFiles_Click(object sender, EventArgs e)
        {
            FolderSelectDialog fsd = new FolderSelectDialog
            {
                InitialDirectory = lastWinPath,
                Title = "Select Folder Containing WIN Reports..."
            };


            if (!fsd.ShowDialog(Handle)) return;
            lastWinPath = fsd.FileName;
            txtWinFiles.Text = lastWinPath;
        }

        private void cmiOpenOriginalFile_Click(object sender, EventArgs e)
        {
            string path = (sender as ToolStripMenuItem).Tag.ToString();

            OpenFile(path);
        }

        private void cmiOpenWINFile_Click(object sender, EventArgs e)
        {
            string path = (sender as ToolStripMenuItem).Tag.ToString();

            OpenFile(path);
        }

        private void dgvFiles_CellContextMenuStripNeeded(object sender,
            DataGridViewCellContextMenuStripNeededEventArgs e)
        {
            if (e.RowIndex == -1 || e.ColumnIndex == -1) return;

            DataGridViewCell clickedCell = (sender as DataGridView)[e.ColumnIndex, e.RowIndex];

            dgvFiles.CurrentCell = clickedCell;

            cmiOpenWINFile.Tag = dgvFiles.Rows[e.RowIndex].Cells["FullPathWIN"].Value.ToString();
            cmiOpenOriginalFile.Tag = dgvFiles.Rows[e.RowIndex].Cells["FullPathOriginal"].Value.ToString();

            e.ContextMenuStrip = cmOpenFile;
        }

        private void dgvFiles_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow row in dgvFiles.Rows)
            {
                if (!row.Cells[6].Value.ToString().ToLower().Contains("true"))
                    row.DefaultCellStyle.ForeColor = Color.Tomato;
            }

            if (!Settings.Default.AddColExtension)
                dgvFiles.Columns["FileExtension"].Visible = false;

            if (!Settings.Default.AddColPathWin)
                dgvFiles.Columns["FullPathWIN"].Visible = false;

            if (!Settings.Default.AddColPathOriginal)
                dgvFiles.Columns["FullPathOriginal"].Visible = false;
        }

        private void EnableControlsAndManageTaskbar(bool state)
        {
            TabControl.TabPageCollection tabs = tcMain.TabPages;

            foreach (TabPage tab in tabs)
            {
                Control.ControlCollection controls = tab.Controls;

                foreach (Control control in controls)
                {
                    if (control.Tag != null && control.Tag.ToString() == "disable")
                        control.Enabled = state;
                }
            }

            tbManager.SetProgressState(!state ? TaskbarProgressBarState.Normal : TaskbarProgressBarState.NoProgress);
        }

        private void ExceptionHandler(string tabName, string userMessage, string exType, string exMessage,
            string exStackTrace)
        {
            tbManager.SetProgressState(TaskbarProgressBarState.Error);
            sslblMain.Text = $"[{tabName}] {userMessage}";
            MessageBox.Show(userMessage, "Unhandled Exception",
                MessageBoxButtons.OK, MessageBoxIcon.Error);

            string logPath = AppDomain.CurrentDomain.BaseDirectory + @"Logs\";
            if (!Directory.Exists(logPath))
                Directory.CreateDirectory(logPath);
            logPath = logPath + "ErrorLog.txt";

            using (StreamWriter sw = new StreamWriter(logPath, true))
            {
                sw.WriteLine("DATE:");
                sw.WriteLine(DateTime.Now);
                sw.WriteLine();
                sw.WriteLine("TYPE:");
                sw.WriteLine(exType);
                sw.WriteLine();
                sw.WriteLine("MESSAGE:");
                sw.WriteLine(exMessage);
                sw.WriteLine();
                sw.WriteLine("STACK TRACE:");
                sw.WriteLine(exStackTrace);
                sw.WriteLine();
                sw.WriteLine("-------------------------------------------------------------------------");
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            switch (WindowState)
            {
                case FormWindowState.Maximized:
                    Settings.Default.Location = RestoreBounds.Location;
                    Settings.Default.Size = RestoreBounds.Size;
                    Settings.Default.Maximized = true;
                    break;
                case FormWindowState.Normal:
                    Settings.Default.Location = Location;
                    Settings.Default.Size = Size;
                    Settings.Default.Maximized = false;
                    break;
                default:
                    Settings.Default.Location = RestoreBounds.Location;
                    Settings.Default.Size = RestoreBounds.Size;
                    break;
            }
            Settings.Default.Save();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            if (Settings.Default.Maximized)
            {
                WindowState = FormWindowState.Maximized;
                Location = Settings.Default.Location;
                Size = Settings.Default.Size;
            }
            else
            {
                Location = Settings.Default.Location;
                Size = Settings.Default.Size;
            }

            cboKeyCombo.DataSource = Settings.Default.KeyCombo;
            cboApp.DataSource = Settings.Default.Application;
            lastOriginalPath = Settings.Default.PathOriginal;
            lastWinPath = Settings.Default.PathWin;
        }

        private static void OpenFile(string path)
        {
            if (File.Exists(path))
                Process.Start(path);
            else
                MessageBox.Show("The file does not exist.", "Unable To Open", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
        }

        private static void OpenFolder(string folderPath)
        {
            if (Directory.Exists(folderPath))
                Process.Start(folderPath);
            else
                MessageBox.Show("This folder does not exist!", "Cannot Open",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        public void RefreshControls()
        {
            cboKeyCombo.DataSource = null;
            cboKeyCombo.DataSource = Settings.Default.KeyCombo;

            cboApp.DataSource = null;
            cboApp.DataSource = Settings.Default.Application;
        }

        private void ResetStatus()
        {
            pbMain.Value = 0;
            sslblMain.Text = "Ready...";
        }

        /// <summary>
        ///     Traps before minimize event, to check state before it.
        ///     Otherwise, when app is closed in minimized state, it would not remember what the previous state was.
        /// </summary>
        protected override void WndProc(ref Message m)
        {
            const char msg = '\x112';
            const int minimize = '\xf020';

            if (m.Msg == msg)
            {
                int param = m.WParam.ToInt32();
                switch (param)
                {
                    case minimize:
                        if (WindowState == FormWindowState.Maximized)
                            Settings.Default.Maximized = true;
                        else
                            Settings.Default.Maximized = false;
                        break;
                }
                Settings.Default.Save();
            }
            base.WndProc(ref m);
        }
    }
}