using ImagingLab.CPanel;
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
    public partial class MainForm : Form
    {
        #region Class methods

        public MainForm()
        {
            InitializeComponent();
            RenderForm();
        }

        void Initialize()
        {
            txt_title.Text = CPanelApp.Current.Data.title;
            label_update.Text = CPanelApp.Current.Data.updated;

            InitGrid(grd_teaching, CPanelApp.Current.Data.teachings);
            InitGrid(grd_people, CPanelApp.Current.Data.people);
            InitGrid(grd_publications, CPanelApp.Current.Data.publications);

            InitMoveButton(grd_people, button_upPeople, true);
            InitMoveButton(grd_people, button_downPeople, false);

            InitMoveButton(grd_publications, button_upPublication, true);
            InitMoveButton(grd_publications, button_downPublication, false);

            InitMoveButton(grd_teaching, button_upTeaching, true);
            InitMoveButton(grd_teaching, button_downTeaching, false);

            grd_teaching.Sort(column_teaching_order, ListSortDirection.Ascending);
            grd_people.Sort(column_people_order, ListSortDirection.Ascending);
            grd_publications.Sort(column_publication_order, ListSortDirection.Ascending);

            grd_teaching.CellDoubleClick += (s, a) => EditTeaching();
            grd_publications.CellDoubleClick += (s, a) => EditPublication();
            grd_people.CellDoubleClick += (s, a) => EditPeople();
        }

        void RenderForm()
        {
            RenderPeople();
            RenderPublication();
            RenderTeching();
        }

        void InitGrid(DataGridView grid, IEnumerable<DataObject> datasource)
        {
            grid.DataSource = datasource;
            grid.CellClick += (s, e) => RenderForm();
            grid.UserDeletingRow += (s, e) => e.Cancel = !ConfirmDelete();
            grid.UserDeletedRow += (s, e) => RenderForm();
        }

        bool SaveData()
        {
            CPanelApp.Current.Data.title = txt_title.Text;
            CPanelApp.Current.Data.updated = DateTime.Now.ToString("MMMM yyyy");
            bool res = CPanelApp.Current.SaveData();
            RenderForm();
            return res;
        }

        bool ConfirmDelete()
        {
            DialogResult res = MessageBox.Show("Are you sure to delete the selected item?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (res == DialogResult.Yes)
            {
                return true;
            }

            return false;
        }

        void DeleteRow(DataGridView grid)
        {
            bool res = ConfirmDelete();
            if (res)
            {
                DataGridViewRow selected = grid.SelectedRows.OfType<DataGridViewRow>().FirstOrDefault();
                if (selected != null)
                {
                    int index = Math.Min(selected.Index, grid.Rows.Count - 2);
                    grid.Rows.Remove(selected);
                    if (index >= 0) grid.Rows[index].Selected = true;
                    RenderForm();
                }
            };
        }

        void InitMoveButton(DataGridView grid, Button btn, bool up)
        {
            btn.Click += (sender, e) =>
            {
                DataGridViewRow current = grid.SelectedRows.OfType<DataGridViewRow>().FirstOrDefault();
                if (current == null) return;
                if ((current.Index == 0 && up) || (current.Index == grid.RowCount - 1 && !up)) return;

                int index = up ? current.Index - 1 : current.Index + 1;
                DataGridViewRow other = grid.Rows[index];

                DataObject currentItem = (current.DataBoundItem as DataObject);
                DataObject otherItem = (other.DataBoundItem as DataObject);

                int temp = currentItem.order;
                currentItem.order = otherItem.order;
                otherItem.order = temp;

                grid.ClearSelection();
                grid.Sort(grid.SortedColumn, ListSortDirection.Ascending);
                grid.Rows[index].Selected = true;
            };
        }

        #endregion

        #region Home

        void MainForm_Load(object sender, EventArgs e)
        {
            Initialize();
        }

        void button_publish_Click(object sender, EventArgs e)
        {
            DialogResult res = folderBrowserDialog1.ShowDialog();
            if (res == DialogResult.OK)
            {
                CPanelApp.Current.Publish(folderBrowserDialog1.SelectedPath);
                MessageBox.Show("Website data is published successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        void button_save_Click(object sender, EventArgs e)
        {
            bool res = SaveData();
            if (res)
            {
                MessageBox.Show("Data is saved successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        void button_upload_Click(object sender, EventArgs e)
        {
            using (CredentialsForm frm = new CredentialsForm())
            {
                DialogResult res = frm.ShowDialog();

                if (res == DialogResult.OK)
                {
                    MessageBox.Show("Data is uploaded successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        void tab_cpanel_SelectedIndexChanged(object sender, EventArgs e)
        {
            RenderForm();
        }

        #endregion

        #region People

        void button_addPeople_Click(object sender, EventArgs e)
        {
            AddPeople();
        }

        void button_editPeople_Click(object sender, EventArgs e)
        {
            EditPeople();
        }

        void button_deletePeople_Click(object sender, EventArgs e)
        {
            DeleteRow(grd_people);
        }

        void AddPeople()
        {
            using (PeopleForm frm = new PeopleForm())
            {
                frm.Text = "Add New Person";
                DialogResult res = frm.ShowDialog();

                if (res == DialogResult.OK)
                {
                    CPanelApp.Current.Data.AddPeople(frm.People);
                    grd_people.Invalidate();
                    grd_people.FirstDisplayedScrollingRowIndex = grd_people.RowCount - 1;
                    grd_people.Rows[grd_people.RowCount - 1].Selected = true;
                }
            }
        }

        void EditPeople()
        {
            if (grd_publications.SelectedRows.Count > 0)
            {
                People item = grd_people.SelectedRows[0].DataBoundItem as People;

                using (PeopleForm frm = new PeopleForm(item))
                {
                    frm.Text = "Edit Person";
                    frm.ShowDialog();
                    grd_people.Invalidate();
                }
            }
        }

        void RenderPeople()
        {
            bool selected = grd_people.SelectedRows.Count > 0;
            button_editPeople.Enabled = selected;
            button_deletePeople.Enabled = selected;
            button_upPeople.Enabled = selected;
            button_downPeople.Enabled = selected;
            grd_people.Invalidate();
        }

        #endregion

        #region Publications

        void button_addPublication_Click(object sender, EventArgs e)
        {
            AddPublication();
        }

        void button_editPublication_Click(object sender, EventArgs e)
        {
            EditPublication();
        }

        void button_deletePublication_Click(object sender, EventArgs e)
        {
            DeleteRow(grd_publications);
        }

        void AddPublication()
        {
            using (PublicationsForm frm = new PublicationsForm())
            {
                frm.Text = "Add New Publication";
                DialogResult res = frm.ShowDialog();

                if (res == DialogResult.OK)
                {
                    CPanelApp.Current.Data.AddPublication(frm.Publication);
                    grd_publications.Invalidate();
                    grd_publications.FirstDisplayedScrollingRowIndex = 0;
                    grd_publications.Rows[0].Selected = true;
                }
            }
        }

        void EditPublication()
        {
            if (grd_publications.SelectedRows.Count > 0)
            {
                Publication item = grd_publications.SelectedRows[0].DataBoundItem as Publication;

                using (PublicationsForm frm = new PublicationsForm(item))
                {
                    frm.Text = "Edit Publication";
                    frm.ShowDialog();
                    grd_publications.Invalidate();
                }
            }
        }

        void RenderPublication()
        {
            bool selected = grd_publications.SelectedRows.Count > 0;
            button_editPublication.Enabled = selected;
            button_deletePublication.Enabled = selected;
            button_upPublication.Enabled = selected;
            button_downPublication.Enabled = selected;
            grd_publications.Invalidate();
        }

        #endregion

        #region Teachings

        void button_addTeaching_Click(object sender, EventArgs e)
        {
            AddTeaching();
        }

        void button_editTeaching_Click(object sender, EventArgs e)
        {
            EditTeaching();
        }

        void button_deleteTeaching_Click(object sender, EventArgs e)
        {
            DeleteRow(grd_teaching);
        }

        void AddTeaching()
        {
            using (TeachingForm frm = new TeachingForm())
            {
                frm.Text = "Add New Teaching";
                DialogResult res = frm.ShowDialog();

                if (res == DialogResult.OK)
                {
                    CPanelApp.Current.Data.AddTeaching(frm.Teaching);
                    grd_teaching.Invalidate();
                    grd_teaching.FirstDisplayedScrollingRowIndex = grd_teaching.RowCount - 1;
                    grd_teaching.Rows[grd_teaching.RowCount - 1].Selected = true;
                }
            }
        }

        void EditTeaching()
        {
            if (grd_teaching.SelectedRows.Count > 0)
            {
                Teaching item = grd_teaching.SelectedRows[0].DataBoundItem as Teaching;

                using (TeachingForm frm = new TeachingForm(item))
                {
                    frm.Text = "Edit Teaching";
                    frm.ShowDialog();
                    grd_teaching.Invalidate();
                }
            }
        }

        void RenderTeching()
        {
            bool selected = grd_teaching.SelectedRows.Count > 0;
            button_editTeaching.Enabled = selected;
            button_deleteTeaching.Enabled = selected;
            button_upTeaching.Enabled = selected;
            button_downTeaching.Enabled = selected;
            grd_teaching.Invalidate();
        }

        #endregion
    }
}
