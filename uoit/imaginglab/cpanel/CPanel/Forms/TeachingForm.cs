using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImagingLab.CPanel
{
    partial class TeachingForm : Form
    {
        public Teaching Teaching { get; set; }

        public TeachingForm(Teaching teaching = null)
        {
            Teaching = teaching ?? new Teaching();
            InitializeComponent();

            AutoValidate = AutoValidate.EnableAllowFocusChange;
            txt_title.Text = teaching?.title ?? "";
            txt_semester.Text = teaching?.semester ?? "";
            txt_description.Text = teaching?.description ?? "";
            txt_university.Text = teaching?.university ?? "UOIT";
            txt_url.Text = teaching?.url ?? "http://www.uoit.ca";
            chk_visible.Checked = teaching?.visible ?? true;
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            if(!this.ValidateChildren())
            {
                MessageBox.Show("Please enter required values!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Teaching.title = txt_title.Text;
            Teaching.semester = txt_semester.Text;
            Teaching.description = txt_description.Text;
            Teaching.university = txt_university.Text;
            Teaching.url = txt_url.Text;
            Teaching.visible = chk_visible.Checked;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
