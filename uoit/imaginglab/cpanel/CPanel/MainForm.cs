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

        #region Home

        private void MainForm_Load(object sender, EventArgs e)
        {
            txt_title.Text = CPanelApp.Current.Data.title;
            label_update.Text = CPanelApp.Current.Data.updated.ToString("MMM yyyy");
            grd_teaching.DataSource = CPanelApp.Current.Data.teachings;
            grd_people.DataSource = CPanelApp.Current.Data.people;
            grd_publications.DataSource = CPanelApp.Current.Data.publications;
        }

        private void button_publish_Click(object sender, EventArgs e)
        {

        }

        private void button_save_Click(object sender, EventArgs e)
        {

        } 

        #endregion

        #region People

        private void button3_addPeople_Click(object sender, EventArgs e)
        {

        }

        private void button_editPeople_Click(object sender, EventArgs e)
        {

        }

        private void button_deletePeople_Click(object sender, EventArgs e)
        {

        }

        private void grd_people_RowEnter(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void grd_people_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {

        }

        #endregion

        #region Publications

        private void button_addPublication_Click(object sender, EventArgs e)
        {

        }

        private void button_editPublication_Click(object sender, EventArgs e)
        {

        }

        private void button_deletePublication_Click(object sender, EventArgs e)
        {

        }

        private void grd_publications_RowEnter(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void grd_publications_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {

        }

        #endregion

        #region Teachings

        private void button_addTeaching_Click(object sender, EventArgs e)
        {

        }

        private void button_editTeaching_Click(object sender, EventArgs e)
        {

        }

        private void button_deleteTeaching_Click(object sender, EventArgs e)
        {

        }

        private void grd_teaching_RowEnter(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void grd_teaching_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {

        }

        #endregion
    }
}
