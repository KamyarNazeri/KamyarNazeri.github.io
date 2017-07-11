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
    partial class PeopleForm : Form
    {
        public People People { get; set; }

        public PeopleForm(People people = null)
        {
            People = people ?? new People();
            InitializeComponent();

            AutoValidate = AutoValidate.EnableAllowFocusChange;
            txt_name.Text = people?.name ?? "";
            txt_email.Text = people?.email ?? "";
            txt_position.Text = people?.position ?? "";
            txt_education.Text = people?.education ?? "";
            txt_start.Text = people?.start ?? "";
            txt_end.Text = people?.end ?? "";
            txt_description.Text = people?.description ?? "";
            chk_alumnus.Checked = people?.alumnus ?? false;
            chk_visible.Checked = people?.visible ?? true;

            if (people?.photo != null && File.Exists(people.photo))
                pic_photo.Image = Image.FromFile(people.photo);
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Please enter required values!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            People.name = txt_name.Text;
            People.email = txt_email.Text;
            People.position = txt_position.Text;
            People.education = txt_education.Text;
            People.start = txt_start.Text;
            People.end = txt_end.Text;
            People.description = txt_description.Text;
            People.alumnus = chk_alumnus.Checked;
            People.visible = chk_visible.Checked;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
