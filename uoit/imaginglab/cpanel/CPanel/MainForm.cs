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
            RenderForm();
        }

        void RenderForm()
        {
            RenderPeople();
            RenderPublication();
            RenderTeching();
        }

        #region Home

        void MainForm_Load(object sender, EventArgs e)
        {
            txt_title.Text = CPanelApp.Current.Data.title;
            label_update.Text = CPanelApp.Current.Data.updated.ToString("MMM yyyy");
            grd_teaching.DataSource = CPanelApp.Current.Data.teachings;
            grd_people.DataSource = CPanelApp.Current.Data.people;
            grd_publications.DataSource = CPanelApp.Current.Data.publications;
        }

        void button_publish_Click(object sender, EventArgs e)
        {

        }

        void button_save_Click(object sender, EventArgs e)
        {

        }

        void tab_cpanel_SelectedIndexChanged(object sender, EventArgs e)
        {
            RenderForm();
        }

        #endregion

        #region People

        private void button_addPeople_Click(object sender, EventArgs e)
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
            RenderPeople();
        }

        void RenderPeople()
        {
            bool selected = grd_people.SelectedRows.Count > 0;
            button_editPeople.Enabled = selected;
            button_deletePeople.Enabled = selected;
        }

        #endregion

        #region Publications

        void button_addPublication_Click(object sender, EventArgs e)
        {

        }

        void button_editPublication_Click(object sender, EventArgs e)
        {

        }

        void button_deletePublication_Click(object sender, EventArgs e)
        {

        }

        void grd_publications_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            RenderPublication();
        }

        void RenderPublication()
        {
            bool selected = grd_publications.SelectedRows.Count > 0;
            button_editPublication.Enabled = selected;
            button_deletePublication.Enabled = selected;
        }

        #endregion

        #region Teachings

        void button_addTeaching_Click(object sender, EventArgs e)
        {

        }

        void button_editTeaching_Click(object sender, EventArgs e)
        {

        }

        void button_deleteTeaching_Click(object sender, EventArgs e)
        {

        }

        void grd_teaching_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            RenderTeching();
        }

        void RenderTeching()
        {
            bool selected = grd_teaching.SelectedRows.Count > 0;
            button_editTeaching.Enabled = selected;
            button_deleteTeaching.Enabled = selected;
        }

        #endregion
    }
}
