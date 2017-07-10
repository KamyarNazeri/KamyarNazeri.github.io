using ImagingLab.CPanel;
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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button_publish_Click(object sender, EventArgs e)
        {

        }

        private void button_save_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            txt_title.Text = CPanelApp.Current.Data.title;
            label_update.Text = CPanelApp.Current.Data.updated.ToString("MMM yyyy");
            grd_teaching.DataSource = CPanelApp.Current.Data.teachings;
            grd_people.DataSource = CPanelApp.Current.Data.people;
            grd_publications.DataSource = CPanelApp.Current.Data.publications;
        }
    }
}
