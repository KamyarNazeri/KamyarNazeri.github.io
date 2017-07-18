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
    partial class PublicationsForm : Form
    {
        string _pdf;
        public Publication Publication { get; set; }
        List<PeoplePublication> PeoplePublication;

        public PublicationsForm(Publication publication = null)
        {
            Publication = publication ?? new Publication();
            PeoplePublication = CPanelApp.Current.Data.people.Select(t => new PeoplePublication
            {
                id = t.id,
                name = t.name,
                selected = publication?.people.Contains(t.id) ?? false
            }).ToList();

            InitializeComponent();

            cmb_type.DataSource = CPanelApp.Current.Data.publicationTypes;
            grd_people.DataSource = PeoplePublication;

            AutoValidate = AutoValidate.EnableAllowFocusChange;
            txt_code.Text = publication?.code ?? "";
            num_year.Value = publication?.year ?? DateTime.Now.Year;
            cmb_type.SelectedItem = publication?.type ?? CPanelApp.Current.Data.publicationTypes.FirstOrDefault();
            txt_url.Text = publication?.url ?? "";
            txt_pdf.Text = publication?.pdf ?? "";
            txt_authors.Text = publication?.authors ?? "";
            txt_title.Text = publication?.title ?? "";
            chk_visible.Checked = publication?.visible ?? true;
            chk_peopleVisible.Checked = publication?.peoplePageVisible ?? true;
            txt_bibtex.Text = publication?.bibtex.Replace("\\n", Environment.NewLine).Replace("<br>", Environment.NewLine).Replace("<br />", Environment.NewLine) ?? "";
            _pdf = publication?.url ?? "";
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

            Publication.code = txt_code.Text;
            Publication.year = Convert.ToInt32(num_year.Value);
            Publication.type = cmb_type.SelectedItem as string;
            Publication.url = txt_url.Text;
            Publication.pdf = txt_pdf.Text;
            Publication.authors = txt_authors.Text;
            Publication.title = txt_title.Text;
            Publication.visible = chk_visible.Checked;
            Publication.peoplePageVisible = chk_peopleVisible.Checked;
            Publication.bibtex = CPanelApp.JSONEncode(txt_bibtex.Text, false);
            Publication.people = new BindingList<int>(PeoplePublication.Where(t => t.selected).Select(t => t.id).ToList());

            if (File.Exists(_pdf))
            {
                FileInfo info = new FileInfo(_pdf);
                Publication.pdf = "data/" + info.Name;
                Publication.PdfPath = info.FullName;
            }
            else
            {
                Publication.pdf = "";
                Publication.PdfPath = null;
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void pic_upload_Click(object sender, EventArgs e)
        {
            DialogResult res = openFileDialog1.ShowDialog();
            if (res == DialogResult.OK)
            {
                _pdf = openFileDialog1.FileName;
                txt_pdf.Text = openFileDialog1.SafeFileName;
            }
        }

        private void pic_cancel_Click(object sender, EventArgs e)
        {
            txt_pdf.Text = "";
            _pdf = null;
        }
    }
}
