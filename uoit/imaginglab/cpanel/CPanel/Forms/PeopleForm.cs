using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace ImagingLab.CPanel
{
    partial class PeopleForm : Form
    {
        public People People { get; set; }
        string _photo;

        public PeopleForm(People people = null)
        {
            People = people ?? new People();
            InitializeComponent();

            AutoValidate = AutoValidate.EnableAllowFocusChange;
            txt_name.Text = people?.name ?? "";
            txt_email.Text = people?.email ?? "";
            txt_title.Text = people?.title ?? "";
            txt_position.Text = people?.position ?? "";
            txt_education.Text = people?.education ?? "";
            txt_start.Text = people?.start ?? "";
            txt_end.Text = people?.end ?? "";
            txt_description.Text = people?.description ?? "";
            txt_research.Text = people?.research ?? "";
            chk_alumnus.Checked = people?.alumnus ?? false;
            chk_visible.Checked = people?.visible ?? true;
            _photo = people?.photo ?? null;

            Render();
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
            People.title = txt_title.Text;
            People.position = txt_position.Text;
            People.education = txt_education.Text;
            People.start = txt_start.Text;
            People.end = txt_end.Text;
            People.research = CPanelApp.JSONEncode(txt_research.Text);
            People.description = CPanelApp.JSONEncode(txt_description.Text);
            People.alumnus = chk_alumnus.Checked;
            People.visible = chk_visible.Checked;

            if (_photo != null)
            {
                FileInfo info = new FileInfo(_photo);
                People.photo = "data/" + info.Name;
                People.PhotoPath = _photo;
            }
            else
            {
                People.photo = "";
                People.PhotoPath = null;
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void pic_photo_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = Environment.CurrentDirectory + "\\data";

            DialogResult res = openFileDialog1.ShowDialog();
            if (res == DialogResult.OK)
            {
                _photo = openFileDialog1.FileName;
                Render();
            }
        }

        private void label_image_Click(object sender, EventArgs e)
        {
            if (File.Exists(_photo))
            {
                _photo = null;
                Render();
            }
        }

        void Render()
        {
            if (File.Exists(_photo))
            {
                using (Image img = Image.FromFile(_photo))
                {
                    pic_photo.Image = img.Clone() as Image;
                }

                label_image.Cursor = Cursors.Hand;
                label_image.Text = "(remove photo)";
                label_image.ForeColor = SystemColors.HotTrack;
            }
            else
            {
                pic_photo.Image = ImagingLab.CPanel.Properties.Resources.noimage;
                label_image.Cursor = Cursors.Default;
                label_image.Text = "(click to change)";
                label_image.ForeColor = SystemColors.ControlDarkDark;
            }
        }
    }
}
