using ImplementersToolbox.Properties;
using System;
using System.Linq;
using System.Windows.Forms;

namespace ImplementersToolbox
{
    public partial class frmSettings : Form
    {
        private readonly frmMain mainForm;

        public frmSettings(frmMain mf)
        {
            InitializeComponent();

            mainForm = mf;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(
                "Are you sure you want to reset settings to defaults? You will not be able to revert this action.",
                "Confirmation Required", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;

            Settings.Default.Reset();

            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ushort keyDelay;

            if (ushort.TryParse(txtSendKeyDelay.Text, out keyDelay))
                Settings.Default.SendKeyDelay = keyDelay;
            else
            {
                MessageBox.Show("Please enter positive integer into Send Key Delay textbox!", "Unable To Save Settings",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            Settings.Default.PathWin = txtWinFiles.Text;
            Settings.Default.PathOriginal = txtOriginalFiles.Text;
            Settings.Default.AddColExtension = clbAdditionalColumns.GetItemChecked(0);
            Settings.Default.AddColPathWin = clbAdditionalColumns.GetItemChecked(1);
            Settings.Default.AddColPathOriginal = clbAdditionalColumns.GetItemChecked(2);
            Settings.Default.IgnoreSystemFiles = clbOtherSettings.GetItemChecked(0);

            Settings.Default.Application.Clear();
            Settings.Default.Application.AddRange(rtxtApps.Lines);

            Settings.Default.KeyCombo.Clear();
            Settings.Default.KeyCombo.AddRange(rtxtKeyCombinations.Lines);

            Settings.Default.Save();

            Close();
        }

        private void frmSettings_FormClosing(object sender, FormClosingEventArgs e)
        {
            mainForm?.RefreshControls();
        }

        private void frmSettings_Load(object sender, EventArgs e)
        {
            txtWinFiles.Text = Settings.Default.PathWin;
            txtOriginalFiles.Text = Settings.Default.PathOriginal;
            clbAdditionalColumns.SetItemChecked(0, Settings.Default.AddColExtension);
            clbAdditionalColumns.SetItemChecked(1, Settings.Default.AddColPathWin);
            clbAdditionalColumns.SetItemChecked(2, Settings.Default.AddColPathOriginal);
            clbOtherSettings.SetItemChecked(0, Settings.Default.IgnoreSystemFiles);
            txtSendKeyDelay.Text = Settings.Default.SendKeyDelay.ToString();
            rtxtApps.Lines = Settings.Default.Application.Cast<string>().ToArray();
            rtxtKeyCombinations.Lines = Settings.Default.KeyCombo.Cast<string>().ToArray();
        }
    }
}