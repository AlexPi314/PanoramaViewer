using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;
using System.Diagnostics;

namespace PanoramaViewer
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();

            if (Convert.ToBoolean(File.ReadAllLines(@"Data\Settings.data")[0].Remove(0, 10)) == true)
            {
                NamePanoramaShowButton.BackColor = Color.YellowGreen;
            }
            if (Convert.ToBoolean(File.ReadAllLines(@"Data\Settings.data")[1].Remove(0, 10)) == true)
            {
                SmoothCameraButton.BackColor = Color.YellowGreen;
            }
            if (Convert.ToBoolean(File.ReadAllLines(@"Data\Settings.data")[2].Remove(0, 10)) == true)
            {
                BigImageButton.BackColor = Color.YellowGreen;
            }

            Text = Program.LocaleWindowsNames[1];

            AdvancedOptionsLabel.Text = Program.LocaleLabelsSF[0];
            ShowPanoramaNameLabel.Text = Program.LocaleLabelsSF[1];
            SmoothCameraLabel.Text = Program.LocaleLabelsSF[2];
            ImageOptionsLabel.Text = Program.LocaleLabelsSF[3];
            ResizeImageLabel.Text = Program.LocaleLabelsSF[4];

            LangLabel.Text = Program.LocaleLabelsSF[5];

            GHButtonToolTip.SetToolTip(GitButton, Program.LocaleLabelsSF[6]);

            for (int i = 0; i < Directory.GetDirectories(@"Localizations").Length; i++)
            {
                if (File.Exists(@"Localizations\"+ Directory.GetDirectories(@"Localizations")[i].Remove(0, 14) + @"\Info.info"))
                {
                    LangComboBox.Items.Add(File.ReadAllLines(@"Localizations\" + Directory.GetDirectories(@"Localizations")[i].Remove(0, 14) + @"\Info.info")[0] + " | " + (Directory.GetDirectories(@"Localizations")[i].Remove(0, 14)));
                }
                else
                {
                    LangComboBox.Items.Add(Directory.GetDirectories(@"Localizations")[i].Remove(0, 14));
                }
                
            }
            //Удаление из списка этих элементов, по скольку они являютья пасхалками
            LangComboBox.Items.Remove("cat-CAT");
            LangComboBox.Items.Remove("dev-DEV");
        }

        private void NamePanoramaShowButton_Click(object sender, EventArgs e)
        {
            if (Program.ShowPanoramaName)
            {
                Program.ShowPanoramaName = false;
                NamePanoramaShowButton.BackColor = Color.OrangeRed;
            }
            else
            {
                Program.ShowPanoramaName = true;
                NamePanoramaShowButton.BackColor = Color.YellowGreen;
            }

            Program.MainF.ShowPanoramaName(Program.ShowPanoramaName);
        }

        private void SmoothCameraButton_Click(object sender, EventArgs e)
        {
            if (Program.SmoothCamera)
            {
                Program.SmoothCamera = false;
                SmoothCameraButton.BackColor = Color.OrangeRed;
            }
            else
            {
                Program.SmoothCamera = true;
                SmoothCameraButton.BackColor = Color.YellowGreen;
            }
        }

        private void BigImageButton_Click(object sender, EventArgs e)
        {
            if (Program.ResizeImage)
            {
                Program.ResizeImage = false;
                BigImageButton.BackColor = Color.OrangeRed;
            }
            else
            {
                Program.ResizeImage = true;
                BigImageButton.BackColor = Color.YellowGreen;
            }
        }

        private void LangComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            File.WriteAllText(@"Localizations\Localization.loc", Convert.ToString(LangComboBox.SelectedItem).Replace(" ", string.Empty).Remove(0, Convert.ToString(LangComboBox.SelectedItem).IndexOf("|")) + "\n1");
            DialogResult result = MessageBox.Show(Program.LocaleMessageBoxes[5], Program.LocaleMessageBoxes[4], MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);

            if (result == DialogResult.Retry)
            {
                Application.Restart();
            }
        }

        private void SettingsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            File.WriteAllText(@"Data\Settings.data", "PnrName - "+ Program.ShowPanoramaName +"\nInertia - "+ Program.SmoothCamera +"\nReszImg - " + Program.ResizeImage);
        }

        private void GitButton_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/AlexPi314/PanoramaViewer");
        }
    }
}
