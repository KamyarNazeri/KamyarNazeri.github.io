namespace ImagingLab.CPanel
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tab_cpanel = new System.Windows.Forms.TabControl();
            this.tabPage_home = new System.Windows.Forms.TabPage();
            this.txt_title = new System.Windows.Forms.TextBox();
            this.label_update = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabPage_people = new System.Windows.Forms.TabPage();
            this.grd_people = new System.Windows.Forms.DataGridView();
            this.peopleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.button_addPeople = new System.Windows.Forms.Button();
            this.button_editPeople = new System.Windows.Forms.Button();
            this.button_deletePeople = new System.Windows.Forms.Button();
            this.tabPage_publication = new System.Windows.Forms.TabPage();
            this.grd_publications = new System.Windows.Forms.DataGridView();
            this.column_publication_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column_publication_code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column_publication_title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column_publication_year = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column_publication_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column_publication_url = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column_publication_pdf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column_publication_bibtex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column_publication_contributors = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column_publication_visible = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.column_publication_peoplePageVisible = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.publicationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel4 = new System.Windows.Forms.Panel();
            this.button_addPublication = new System.Windows.Forms.Button();
            this.button_editPublication = new System.Windows.Forms.Button();
            this.button_deletePublication = new System.Windows.Forms.Button();
            this.tabPage_teaching = new System.Windows.Forms.TabPage();
            this.grd_teaching = new System.Windows.Forms.DataGridView();
            this.column_teaching_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column_teaching_semester = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column_teaching_title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column_teaching_description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column_teaching_university = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column_teaching_url = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column_teaching_visible = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.teachingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.button_addTeaching = new System.Windows.Forms.Button();
            this.button_editTeaching = new System.Windows.Forms.Button();
            this.button_deleteTeaching = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_save = new System.Windows.Forms.Button();
            this.button_publish = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.column_people_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column_people_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column_people_email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column_people_title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column_people_position = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column_people_education = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column_people_description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column_people_start = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column_people_end = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column_people_alumnus = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.column_people_visible = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tab_cpanel.SuspendLayout();
            this.tabPage_home.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage_people.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd_people)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.peopleBindingSource)).BeginInit();
            this.panel3.SuspendLayout();
            this.tabPage_publication.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd_publications)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.publicationBindingSource)).BeginInit();
            this.panel4.SuspendLayout();
            this.tabPage_teaching.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd_teaching)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teachingBindingSource)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab_cpanel
            // 
            this.tab_cpanel.Controls.Add(this.tabPage_home);
            this.tab_cpanel.Controls.Add(this.tabPage_people);
            this.tab_cpanel.Controls.Add(this.tabPage_publication);
            this.tab_cpanel.Controls.Add(this.tabPage_teaching);
            this.tab_cpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tab_cpanel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tab_cpanel.HotTrack = true;
            this.tab_cpanel.Location = new System.Drawing.Point(0, 0);
            this.tab_cpanel.Name = "tab_cpanel";
            this.tab_cpanel.SelectedIndex = 0;
            this.tab_cpanel.Size = new System.Drawing.Size(1082, 509);
            this.tab_cpanel.TabIndex = 0;
            this.tab_cpanel.SelectedIndexChanged += new System.EventHandler(this.tab_cpanel_SelectedIndexChanged);
            // 
            // tabPage_home
            // 
            this.tabPage_home.BackColor = System.Drawing.Color.White;
            this.tabPage_home.Controls.Add(this.txt_title);
            this.tabPage_home.Controls.Add(this.label_update);
            this.tabPage_home.Controls.Add(this.label2);
            this.tabPage_home.Controls.Add(this.label1);
            this.tabPage_home.Controls.Add(this.pictureBox1);
            this.tabPage_home.Location = new System.Drawing.Point(4, 24);
            this.tabPage_home.Name = "tabPage_home";
            this.tabPage_home.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_home.Size = new System.Drawing.Size(1074, 481);
            this.tabPage_home.TabIndex = 0;
            this.tabPage_home.Text = " HOME ";
            // 
            // txt_title
            // 
            this.txt_title.Location = new System.Drawing.Point(151, 163);
            this.txt_title.Name = "txt_title";
            this.txt_title.Size = new System.Drawing.Size(300, 23);
            this.txt_title.TabIndex = 3;
            // 
            // label_update
            // 
            this.label_update.AutoSize = true;
            this.label_update.Location = new System.Drawing.Point(148, 132);
            this.label_update.Name = "label_update";
            this.label_update.Size = new System.Drawing.Size(48, 16);
            this.label_update.TabIndex = 2;
            this.label_update.Text = "[date]";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Website Title:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Update Date:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ImagingLab.CPanel.Properties.Resources.title;
            this.pictureBox1.Location = new System.Drawing.Point(30, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(225, 62);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // tabPage_people
            // 
            this.tabPage_people.BackColor = System.Drawing.Color.White;
            this.tabPage_people.Controls.Add(this.grd_people);
            this.tabPage_people.Controls.Add(this.panel3);
            this.tabPage_people.Location = new System.Drawing.Point(4, 24);
            this.tabPage_people.Name = "tabPage_people";
            this.tabPage_people.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_people.Size = new System.Drawing.Size(1074, 481);
            this.tabPage_people.TabIndex = 2;
            this.tabPage_people.Text = " PEOPLE ";
            // 
            // grd_people
            // 
            this.grd_people.AllowUserToAddRows = false;
            this.grd_people.AllowUserToResizeRows = false;
            this.grd_people.AutoGenerateColumns = false;
            this.grd_people.BackgroundColor = System.Drawing.Color.White;
            this.grd_people.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd_people.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.column_people_id,
            this.column_people_name,
            this.column_people_email,
            this.column_people_title,
            this.column_people_position,
            this.column_people_education,
            this.column_people_description,
            this.column_people_start,
            this.column_people_end,
            this.column_people_alumnus,
            this.column_people_visible});
            this.grd_people.DataSource = this.peopleBindingSource;
            this.grd_people.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grd_people.Location = new System.Drawing.Point(3, 3);
            this.grd_people.Name = "grd_people";
            this.grd_people.RowHeadersWidth = 20;
            this.grd_people.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grd_people.RowTemplate.Height = 24;
            this.grd_people.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grd_people.Size = new System.Drawing.Size(1068, 440);
            this.grd_people.TabIndex = 1;
            // 
            // peopleBindingSource
            // 
            this.peopleBindingSource.DataSource = typeof(ImagingLab.CPanel.People);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button_addPeople);
            this.panel3.Controls.Add(this.button_editPeople);
            this.panel3.Controls.Add(this.button_deletePeople);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(3, 443);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1068, 35);
            this.panel3.TabIndex = 0;
            // 
            // button_addPeople
            // 
            this.button_addPeople.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_addPeople.Location = new System.Drawing.Point(5, 6);
            this.button_addPeople.Name = "button_addPeople";
            this.button_addPeople.Size = new System.Drawing.Size(80, 25);
            this.button_addPeople.TabIndex = 1;
            this.button_addPeople.Text = "Add";
            this.button_addPeople.UseVisualStyleBackColor = true;
            this.button_addPeople.Click += new System.EventHandler(this.button_addPeople_Click);
            // 
            // button_editPeople
            // 
            this.button_editPeople.Enabled = false;
            this.button_editPeople.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_editPeople.Location = new System.Drawing.Point(91, 6);
            this.button_editPeople.Name = "button_editPeople";
            this.button_editPeople.Size = new System.Drawing.Size(80, 25);
            this.button_editPeople.TabIndex = 1;
            this.button_editPeople.Text = "Edit";
            this.button_editPeople.UseVisualStyleBackColor = true;
            this.button_editPeople.Click += new System.EventHandler(this.button_editPeople_Click);
            // 
            // button_deletePeople
            // 
            this.button_deletePeople.Enabled = false;
            this.button_deletePeople.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_deletePeople.Location = new System.Drawing.Point(177, 6);
            this.button_deletePeople.Name = "button_deletePeople";
            this.button_deletePeople.Size = new System.Drawing.Size(80, 25);
            this.button_deletePeople.TabIndex = 1;
            this.button_deletePeople.Text = "Delete";
            this.button_deletePeople.UseVisualStyleBackColor = true;
            this.button_deletePeople.Click += new System.EventHandler(this.button_deletePeople_Click);
            // 
            // tabPage_publication
            // 
            this.tabPage_publication.BackColor = System.Drawing.Color.White;
            this.tabPage_publication.Controls.Add(this.grd_publications);
            this.tabPage_publication.Controls.Add(this.panel4);
            this.tabPage_publication.Location = new System.Drawing.Point(4, 24);
            this.tabPage_publication.Name = "tabPage_publication";
            this.tabPage_publication.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_publication.Size = new System.Drawing.Size(1074, 481);
            this.tabPage_publication.TabIndex = 1;
            this.tabPage_publication.Text = " PUBLICATION ";
            // 
            // grd_publications
            // 
            this.grd_publications.AllowUserToAddRows = false;
            this.grd_publications.AllowUserToResizeRows = false;
            this.grd_publications.AutoGenerateColumns = false;
            this.grd_publications.BackgroundColor = System.Drawing.Color.White;
            this.grd_publications.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd_publications.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.column_publication_id,
            this.column_publication_code,
            this.column_publication_title,
            this.column_publication_year,
            this.column_publication_type,
            this.column_publication_url,
            this.column_publication_pdf,
            this.column_publication_bibtex,
            this.column_publication_contributors,
            this.column_publication_visible,
            this.column_publication_peoplePageVisible});
            this.grd_publications.DataSource = this.publicationBindingSource;
            this.grd_publications.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grd_publications.Location = new System.Drawing.Point(3, 3);
            this.grd_publications.MultiSelect = false;
            this.grd_publications.Name = "grd_publications";
            this.grd_publications.RowHeadersWidth = 20;
            this.grd_publications.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grd_publications.RowTemplate.Height = 24;
            this.grd_publications.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grd_publications.Size = new System.Drawing.Size(1068, 440);
            this.grd_publications.TabIndex = 1;
            // 
            // column_publication_id
            // 
            this.column_publication_id.DataPropertyName = "id";
            this.column_publication_id.HeaderText = "ID";
            this.column_publication_id.Name = "column_publication_id";
            this.column_publication_id.Visible = false;
            // 
            // column_publication_code
            // 
            this.column_publication_code.DataPropertyName = "code";
            this.column_publication_code.HeaderText = "Code";
            this.column_publication_code.Name = "column_publication_code";
            this.column_publication_code.Width = 50;
            // 
            // column_publication_title
            // 
            this.column_publication_title.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.column_publication_title.DataPropertyName = "title";
            this.column_publication_title.HeaderText = "Title";
            this.column_publication_title.MinimumWidth = 150;
            this.column_publication_title.Name = "column_publication_title";
            // 
            // column_publication_year
            // 
            this.column_publication_year.DataPropertyName = "year";
            this.column_publication_year.HeaderText = "Year";
            this.column_publication_year.Name = "column_publication_year";
            this.column_publication_year.Width = 50;
            // 
            // column_publication_type
            // 
            this.column_publication_type.DataPropertyName = "type";
            this.column_publication_type.HeaderText = "Type";
            this.column_publication_type.Name = "column_publication_type";
            this.column_publication_type.Width = 120;
            // 
            // column_publication_url
            // 
            this.column_publication_url.DataPropertyName = "url";
            this.column_publication_url.HeaderText = "Url";
            this.column_publication_url.Name = "column_publication_url";
            this.column_publication_url.Width = 120;
            // 
            // column_publication_pdf
            // 
            this.column_publication_pdf.DataPropertyName = "pdf";
            this.column_publication_pdf.HeaderText = "PDF";
            this.column_publication_pdf.Name = "column_publication_pdf";
            this.column_publication_pdf.Width = 120;
            // 
            // column_publication_bibtex
            // 
            this.column_publication_bibtex.DataPropertyName = "bibtex";
            this.column_publication_bibtex.HeaderText = "BibTex";
            this.column_publication_bibtex.Name = "column_publication_bibtex";
            // 
            // column_publication_contributors
            // 
            this.column_publication_contributors.DataPropertyName = "contributors";
            this.column_publication_contributors.HeaderText = "Contributors";
            this.column_publication_contributors.Name = "column_publication_contributors";
            // 
            // column_publication_visible
            // 
            this.column_publication_visible.DataPropertyName = "visible";
            this.column_publication_visible.HeaderText = "Visible";
            this.column_publication_visible.Name = "column_publication_visible";
            this.column_publication_visible.Width = 60;
            // 
            // column_publication_peoplePageVisible
            // 
            this.column_publication_peoplePageVisible.DataPropertyName = "peoplePageVisible";
            this.column_publication_peoplePageVisible.HeaderText = "People Visible";
            this.column_publication_peoplePageVisible.Name = "column_publication_peoplePageVisible";
            this.column_publication_peoplePageVisible.Width = 115;
            // 
            // publicationBindingSource
            // 
            this.publicationBindingSource.DataSource = typeof(ImagingLab.CPanel.Publication);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.button_addPublication);
            this.panel4.Controls.Add(this.button_editPublication);
            this.panel4.Controls.Add(this.button_deletePublication);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(3, 443);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1068, 35);
            this.panel4.TabIndex = 0;
            // 
            // button_addPublication
            // 
            this.button_addPublication.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_addPublication.Location = new System.Drawing.Point(5, 6);
            this.button_addPublication.Name = "button_addPublication";
            this.button_addPublication.Size = new System.Drawing.Size(80, 25);
            this.button_addPublication.TabIndex = 2;
            this.button_addPublication.Text = "Add";
            this.button_addPublication.UseVisualStyleBackColor = true;
            this.button_addPublication.Click += new System.EventHandler(this.button_addPublication_Click);
            // 
            // button_editPublication
            // 
            this.button_editPublication.Enabled = false;
            this.button_editPublication.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_editPublication.Location = new System.Drawing.Point(91, 6);
            this.button_editPublication.Name = "button_editPublication";
            this.button_editPublication.Size = new System.Drawing.Size(80, 25);
            this.button_editPublication.TabIndex = 3;
            this.button_editPublication.Text = "Edit";
            this.button_editPublication.UseVisualStyleBackColor = true;
            this.button_editPublication.Click += new System.EventHandler(this.button_editPublication_Click);
            // 
            // button_deletePublication
            // 
            this.button_deletePublication.Enabled = false;
            this.button_deletePublication.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_deletePublication.Location = new System.Drawing.Point(177, 6);
            this.button_deletePublication.Name = "button_deletePublication";
            this.button_deletePublication.Size = new System.Drawing.Size(80, 25);
            this.button_deletePublication.TabIndex = 4;
            this.button_deletePublication.Text = "Delete";
            this.button_deletePublication.UseVisualStyleBackColor = true;
            this.button_deletePublication.Click += new System.EventHandler(this.button_deletePublication_Click);
            // 
            // tabPage_teaching
            // 
            this.tabPage_teaching.BackColor = System.Drawing.Color.White;
            this.tabPage_teaching.Controls.Add(this.grd_teaching);
            this.tabPage_teaching.Controls.Add(this.panel2);
            this.tabPage_teaching.Location = new System.Drawing.Point(4, 24);
            this.tabPage_teaching.Name = "tabPage_teaching";
            this.tabPage_teaching.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_teaching.Size = new System.Drawing.Size(1074, 481);
            this.tabPage_teaching.TabIndex = 3;
            this.tabPage_teaching.Text = " TEACHING ";
            // 
            // grd_teaching
            // 
            this.grd_teaching.AllowUserToAddRows = false;
            this.grd_teaching.AllowUserToResizeRows = false;
            this.grd_teaching.AutoGenerateColumns = false;
            this.grd_teaching.BackgroundColor = System.Drawing.Color.White;
            this.grd_teaching.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd_teaching.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.column_teaching_id,
            this.column_teaching_semester,
            this.column_teaching_title,
            this.column_teaching_description,
            this.column_teaching_university,
            this.column_teaching_url,
            this.column_teaching_visible});
            this.grd_teaching.DataSource = this.teachingBindingSource;
            this.grd_teaching.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grd_teaching.Location = new System.Drawing.Point(3, 3);
            this.grd_teaching.MultiSelect = false;
            this.grd_teaching.Name = "grd_teaching";
            this.grd_teaching.RowHeadersWidth = 20;
            this.grd_teaching.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grd_teaching.RowTemplate.Height = 24;
            this.grd_teaching.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grd_teaching.Size = new System.Drawing.Size(1068, 440);
            this.grd_teaching.TabIndex = 1;
            // 
            // column_teaching_id
            // 
            this.column_teaching_id.DataPropertyName = "id";
            this.column_teaching_id.HeaderText = "ID";
            this.column_teaching_id.Name = "column_teaching_id";
            this.column_teaching_id.Visible = false;
            // 
            // column_teaching_semester
            // 
            this.column_teaching_semester.DataPropertyName = "semester";
            this.column_teaching_semester.HeaderText = "Semester";
            this.column_teaching_semester.Name = "column_teaching_semester";
            this.column_teaching_semester.Width = 120;
            // 
            // column_teaching_title
            // 
            this.column_teaching_title.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.column_teaching_title.DataPropertyName = "title";
            this.column_teaching_title.FillWeight = 30F;
            this.column_teaching_title.HeaderText = "Title";
            this.column_teaching_title.Name = "column_teaching_title";
            // 
            // column_teaching_description
            // 
            this.column_teaching_description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.column_teaching_description.DataPropertyName = "description";
            this.column_teaching_description.FillWeight = 70F;
            this.column_teaching_description.HeaderText = "Description";
            this.column_teaching_description.Name = "column_teaching_description";
            // 
            // column_teaching_university
            // 
            this.column_teaching_university.DataPropertyName = "university";
            this.column_teaching_university.HeaderText = "University";
            this.column_teaching_university.Name = "column_teaching_university";
            this.column_teaching_university.Width = 130;
            // 
            // column_teaching_url
            // 
            this.column_teaching_url.DataPropertyName = "url";
            this.column_teaching_url.HeaderText = "Url";
            this.column_teaching_url.Name = "column_teaching_url";
            this.column_teaching_url.Width = 160;
            // 
            // column_teaching_visible
            // 
            this.column_teaching_visible.DataPropertyName = "visible";
            this.column_teaching_visible.HeaderText = "Visible";
            this.column_teaching_visible.Name = "column_teaching_visible";
            this.column_teaching_visible.Width = 60;
            // 
            // teachingBindingSource
            // 
            this.teachingBindingSource.DataSource = typeof(ImagingLab.CPanel.Teaching);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button_addTeaching);
            this.panel2.Controls.Add(this.button_editTeaching);
            this.panel2.Controls.Add(this.button_deleteTeaching);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(3, 443);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1068, 35);
            this.panel2.TabIndex = 0;
            // 
            // button_addTeaching
            // 
            this.button_addTeaching.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_addTeaching.Location = new System.Drawing.Point(5, 6);
            this.button_addTeaching.Name = "button_addTeaching";
            this.button_addTeaching.Size = new System.Drawing.Size(80, 25);
            this.button_addTeaching.TabIndex = 5;
            this.button_addTeaching.Text = "Add";
            this.button_addTeaching.UseVisualStyleBackColor = true;
            this.button_addTeaching.Click += new System.EventHandler(this.button_addTeaching_Click);
            // 
            // button_editTeaching
            // 
            this.button_editTeaching.Enabled = false;
            this.button_editTeaching.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_editTeaching.Location = new System.Drawing.Point(91, 6);
            this.button_editTeaching.Name = "button_editTeaching";
            this.button_editTeaching.Size = new System.Drawing.Size(80, 25);
            this.button_editTeaching.TabIndex = 6;
            this.button_editTeaching.Text = "Edit";
            this.button_editTeaching.UseVisualStyleBackColor = true;
            this.button_editTeaching.Click += new System.EventHandler(this.button_editTeaching_Click);
            // 
            // button_deleteTeaching
            // 
            this.button_deleteTeaching.Enabled = false;
            this.button_deleteTeaching.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_deleteTeaching.Location = new System.Drawing.Point(177, 6);
            this.button_deleteTeaching.Name = "button_deleteTeaching";
            this.button_deleteTeaching.Size = new System.Drawing.Size(80, 25);
            this.button_deleteTeaching.TabIndex = 7;
            this.button_deleteTeaching.Text = "Delete";
            this.button_deleteTeaching.UseVisualStyleBackColor = true;
            this.button_deleteTeaching.Click += new System.EventHandler(this.button_deleteTeaching_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.Add(this.button_save);
            this.panel1.Controls.Add(this.button_publish);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(0, 509);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1082, 44);
            this.panel1.TabIndex = 1;
            // 
            // button_save
            // 
            this.button_save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_save.Location = new System.Drawing.Point(884, 6);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(90, 30);
            this.button_save.TabIndex = 0;
            this.button_save.Text = "Save";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // button_publish
            // 
            this.button_publish.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_publish.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_publish.Location = new System.Drawing.Point(980, 6);
            this.button_publish.Name = "button_publish";
            this.button_publish.Size = new System.Drawing.Size(90, 30);
            this.button_publish.TabIndex = 0;
            this.button_publish.Text = "Publish";
            this.button_publish.UseVisualStyleBackColor = true;
            this.button_publish.Click += new System.EventHandler(this.button_publish_Click);
            // 
            // column_people_id
            // 
            this.column_people_id.DataPropertyName = "id";
            this.column_people_id.HeaderText = "ID";
            this.column_people_id.Name = "column_people_id";
            this.column_people_id.Visible = false;
            // 
            // column_people_name
            // 
            this.column_people_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.column_people_name.DataPropertyName = "name";
            this.column_people_name.FillWeight = 20F;
            this.column_people_name.HeaderText = "Name";
            this.column_people_name.MinimumWidth = 120;
            this.column_people_name.Name = "column_people_name";
            // 
            // column_people_email
            // 
            this.column_people_email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.column_people_email.DataPropertyName = "email";
            this.column_people_email.FillWeight = 20F;
            this.column_people_email.HeaderText = "Email";
            this.column_people_email.MinimumWidth = 120;
            this.column_people_email.Name = "column_people_email";
            // 
            // column_people_title
            // 
            this.column_people_title.DataPropertyName = "title";
            this.column_people_title.HeaderText = "Title";
            this.column_people_title.MinimumWidth = 100;
            this.column_people_title.Name = "column_people_title";
            this.column_people_title.Width = 120;
            // 
            // column_people_position
            // 
            this.column_people_position.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.column_people_position.DataPropertyName = "position";
            this.column_people_position.FillWeight = 20F;
            this.column_people_position.HeaderText = "Position";
            this.column_people_position.MinimumWidth = 100;
            this.column_people_position.Name = "column_people_position";
            // 
            // column_people_education
            // 
            this.column_people_education.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.column_people_education.DataPropertyName = "education";
            this.column_people_education.FillWeight = 20F;
            this.column_people_education.HeaderText = "Education";
            this.column_people_education.MinimumWidth = 50;
            this.column_people_education.Name = "column_people_education";
            // 
            // column_people_description
            // 
            this.column_people_description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.column_people_description.DataPropertyName = "description";
            this.column_people_description.FillWeight = 20F;
            this.column_people_description.HeaderText = "Description";
            this.column_people_description.MinimumWidth = 50;
            this.column_people_description.Name = "column_people_description";
            // 
            // column_people_start
            // 
            this.column_people_start.DataPropertyName = "start";
            this.column_people_start.HeaderText = "Start";
            this.column_people_start.Name = "column_people_start";
            this.column_people_start.Width = 120;
            // 
            // column_people_end
            // 
            this.column_people_end.DataPropertyName = "end";
            this.column_people_end.HeaderText = "End";
            this.column_people_end.Name = "column_people_end";
            this.column_people_end.Width = 120;
            // 
            // column_people_alumnus
            // 
            this.column_people_alumnus.DataPropertyName = "alumnus";
            this.column_people_alumnus.HeaderText = "Alumnus";
            this.column_people_alumnus.Name = "column_people_alumnus";
            this.column_people_alumnus.Width = 67;
            // 
            // column_people_visible
            // 
            this.column_people_visible.DataPropertyName = "visible";
            this.column_people_visible.HeaderText = "Visible";
            this.column_people_visible.Name = "column_people_visible";
            this.column_people_visible.Width = 57;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1082, 553);
            this.Controls.Add(this.tab_cpanel);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(500, 400);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ImagingLab Control Panel";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tab_cpanel.ResumeLayout(false);
            this.tabPage_home.ResumeLayout(false);
            this.tabPage_home.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage_people.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grd_people)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.peopleBindingSource)).EndInit();
            this.panel3.ResumeLayout(false);
            this.tabPage_publication.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grd_publications)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.publicationBindingSource)).EndInit();
            this.panel4.ResumeLayout(false);
            this.tabPage_teaching.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grd_teaching)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teachingBindingSource)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tab_cpanel;
        private System.Windows.Forms.TabPage tabPage_home;
        private System.Windows.Forms.TabPage tabPage_publication;
        private System.Windows.Forms.TabPage tabPage_people;
        private System.Windows.Forms.TabPage tabPage_teaching;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_publish;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label_update;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_title;
        private System.Windows.Forms.DataGridView grd_teaching;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.BindingSource teachingBindingSource;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView grd_people;
        private System.Windows.Forms.BindingSource peopleBindingSource;
        private System.Windows.Forms.DataGridView grd_publications;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.BindingSource publicationBindingSource;
        private System.Windows.Forms.Button button_addPeople;
        private System.Windows.Forms.Button button_editPeople;
        private System.Windows.Forms.Button button_deletePeople;
        private System.Windows.Forms.Button button_addPublication;
        private System.Windows.Forms.Button button_editPublication;
        private System.Windows.Forms.Button button_deletePublication;
        private System.Windows.Forms.Button button_addTeaching;
        private System.Windows.Forms.Button button_editTeaching;
        private System.Windows.Forms.Button button_deleteTeaching;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.DataGridViewTextBoxColumn column_teaching_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn column_teaching_semester;
        private System.Windows.Forms.DataGridViewTextBoxColumn column_teaching_title;
        private System.Windows.Forms.DataGridViewTextBoxColumn column_teaching_description;
        private System.Windows.Forms.DataGridViewTextBoxColumn column_teaching_university;
        private System.Windows.Forms.DataGridViewTextBoxColumn column_teaching_url;
        private System.Windows.Forms.DataGridViewCheckBoxColumn column_teaching_visible;
        private System.Windows.Forms.DataGridViewTextBoxColumn column_publication_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn column_publication_code;
        private System.Windows.Forms.DataGridViewTextBoxColumn column_publication_title;
        private System.Windows.Forms.DataGridViewTextBoxColumn column_publication_year;
        private System.Windows.Forms.DataGridViewTextBoxColumn column_publication_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn column_publication_url;
        private System.Windows.Forms.DataGridViewTextBoxColumn column_publication_pdf;
        private System.Windows.Forms.DataGridViewTextBoxColumn column_publication_bibtex;
        private System.Windows.Forms.DataGridViewTextBoxColumn column_publication_contributors;
        private System.Windows.Forms.DataGridViewCheckBoxColumn column_publication_visible;
        private System.Windows.Forms.DataGridViewCheckBoxColumn column_publication_peoplePageVisible;
        private System.Windows.Forms.DataGridViewTextBoxColumn column_people_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn column_people_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn column_people_email;
        private System.Windows.Forms.DataGridViewTextBoxColumn column_people_title;
        private System.Windows.Forms.DataGridViewTextBoxColumn column_people_position;
        private System.Windows.Forms.DataGridViewTextBoxColumn column_people_education;
        private System.Windows.Forms.DataGridViewTextBoxColumn column_people_description;
        private System.Windows.Forms.DataGridViewTextBoxColumn column_people_start;
        private System.Windows.Forms.DataGridViewTextBoxColumn column_people_end;
        private System.Windows.Forms.DataGridViewCheckBoxColumn column_people_alumnus;
        private System.Windows.Forms.DataGridViewCheckBoxColumn column_people_visible;
    }
}

