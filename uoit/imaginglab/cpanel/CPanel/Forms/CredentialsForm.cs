using ImagingLab.CPanel.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImagingLab.CPanel
{
    public partial class CredentialsForm : Form
    {
        public CredentialsForm()
        {
            AutoValidate = AutoValidate.EnableAllowFocusChange;
            InitializeComponent();

            txt_username.Text = AppSettings.Current.Username ?? "";
            txt_password.Text = AppSettings.Current.Password ?? "";
            chk_savePassword.Checked = !String.IsNullOrEmpty(txt_password.Text);
            ActiveControl = txt_username;
        }

        async void button_upload_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Please enter required values!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            panel_container.Enabled = false;
            this.Text = "Uploading...";

            if (!chk_savePassword.Checked)
            {
                AppSettings.Current.Password = "";
                AppSettings.Current.Save();
            }

            CPanelApp.UploadResult res = await CPanelApp.Current.Upload(txt_username.Text, txt_password.Text);

            if (res.Success)
            {
                AppSettings.Current.Username = txt_username.Text;
                AppSettings.Current.Password = chk_savePassword.Checked ? txt_password.Text : "";
                AppSettings.Current.Save();
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                panel_container.Enabled = true;
                this.Text = "Server Credentials";
                MessageBox.Show("Error uploading data: " + res.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
