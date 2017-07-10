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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage_home = new System.Windows.Forms.TabPage();
            this.txt_title = new System.Windows.Forms.TextBox();
            this.label_update = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabPage_publication = new System.Windows.Forms.TabPage();
            this.tabPage_people = new System.Windows.Forms.TabPage();
            this.grd_people = new System.Windows.Forms.DataGridView();
            this.peopleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.tabPage_teaching = new System.Windows.Forms.TabPage();
            this.grd_teaching = new System.Windows.Forms.DataGridView();
            this.teachingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_save = new System.Windows.Forms.Button();
            this.button_publish = new System.Windows.Forms.Button();
            this.semesterDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.universityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urlDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel4 = new System.Windows.Forms.Panel();
            this.grd_publications = new System.Windows.Forms.DataGridView();
            this.publicationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.codeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urlDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pdfDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bibtexDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contributorsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publicationsPageVisibleDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.peoplePageVisibleDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.positionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.educationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.photoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alumniDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.visibleDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage_home.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage_publication.SuspendLayout();
            this.tabPage_people.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd_people)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.peopleBindingSource)).BeginInit();
            this.tabPage_teaching.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd_teaching)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teachingBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd_publications)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.publicationBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage_home);
            this.tabControl1.Controls.Add(this.tabPage_people);
            this.tabControl1.Controls.Add(this.tabPage_publication);
            this.tabControl1.Controls.Add(this.tabPage_teaching);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.HotTrack = true;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1082, 509);
            this.tabControl1.TabIndex = 0;
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
            this.grd_people.AllowUserToResizeRows = false;
            this.grd_people.AutoGenerateColumns = false;
            this.grd_people.BackgroundColor = System.Drawing.Color.White;
            this.grd_people.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd_people.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.positionDataGridViewTextBoxColumn,
            this.educationDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.startDataGridViewTextBoxColumn,
            this.endDataGridViewTextBoxColumn,
            this.photoDataGridViewTextBoxColumn,
            this.alumniDataGridViewCheckBoxColumn,
            this.visibleDataGridViewCheckBoxColumn});
            this.grd_people.DataSource = this.peopleBindingSource;
            this.grd_people.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grd_people.Location = new System.Drawing.Point(3, 3);
            this.grd_people.Name = "grd_people";
            this.grd_people.RowHeadersWidth = 20;
            this.grd_people.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grd_people.RowTemplate.Height = 24;
            this.grd_people.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grd_people.Size = new System.Drawing.Size(1068, 435);
            this.grd_people.TabIndex = 1;
            // 
            // peopleBindingSource
            // 
            this.peopleBindingSource.DataSource = typeof(ImagingLab.CPanel.People);
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(3, 438);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1068, 40);
            this.panel3.TabIndex = 0;
            // 
            // tabPage_teaching
            // 
            this.tabPage_teaching.BackColor = System.Drawing.Color.White;
            this.tabPage_teaching.Controls.Add(this.grd_teaching);
            this.tabPage_teaching.Controls.Add(this.panel2);
            this.tabPage_teaching.Location = new System.Drawing.Point(4, 24);
            this.tabPage_teaching.Name = "tabPage_teaching";
            this.tabPage_teaching.Size = new System.Drawing.Size(1074, 481);
            this.tabPage_teaching.TabIndex = 3;
            this.tabPage_teaching.Text = " TEACHING ";
            // 
            // grd_teaching
            // 
            this.grd_teaching.AllowUserToResizeRows = false;
            this.grd_teaching.AutoGenerateColumns = false;
            this.grd_teaching.BackgroundColor = System.Drawing.Color.White;
            this.grd_teaching.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd_teaching.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.semesterDataGridViewTextBoxColumn,
            this.titleDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn1,
            this.universityDataGridViewTextBoxColumn,
            this.urlDataGridViewTextBoxColumn});
            this.grd_teaching.DataSource = this.teachingBindingSource;
            this.grd_teaching.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grd_teaching.Location = new System.Drawing.Point(0, 0);
            this.grd_teaching.Name = "grd_teaching";
            this.grd_teaching.RowHeadersWidth = 20;
            this.grd_teaching.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grd_teaching.RowTemplate.Height = 24;
            this.grd_teaching.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grd_teaching.Size = new System.Drawing.Size(1074, 441);
            this.grd_teaching.TabIndex = 1;
            // 
            // teachingBindingSource
            // 
            this.teachingBindingSource.DataSource = typeof(ImagingLab.CPanel.Teaching);
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 441);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1074, 40);
            this.panel2.TabIndex = 0;
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
            // semesterDataGridViewTextBoxColumn
            // 
            this.semesterDataGridViewTextBoxColumn.DataPropertyName = "semester";
            this.semesterDataGridViewTextBoxColumn.HeaderText = "Semester";
            this.semesterDataGridViewTextBoxColumn.Name = "semesterDataGridViewTextBoxColumn";
            this.semesterDataGridViewTextBoxColumn.Width = 120;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "title";
            this.titleDataGridViewTextBoxColumn.FillWeight = 30F;
            this.titleDataGridViewTextBoxColumn.HeaderText = "Title";
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            // 
            // descriptionDataGridViewTextBoxColumn1
            // 
            this.descriptionDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.descriptionDataGridViewTextBoxColumn1.DataPropertyName = "description";
            this.descriptionDataGridViewTextBoxColumn1.FillWeight = 70F;
            this.descriptionDataGridViewTextBoxColumn1.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn1.Name = "descriptionDataGridViewTextBoxColumn1";
            // 
            // universityDataGridViewTextBoxColumn
            // 
            this.universityDataGridViewTextBoxColumn.DataPropertyName = "university";
            this.universityDataGridViewTextBoxColumn.HeaderText = "University";
            this.universityDataGridViewTextBoxColumn.Name = "universityDataGridViewTextBoxColumn";
            this.universityDataGridViewTextBoxColumn.Width = 120;
            // 
            // urlDataGridViewTextBoxColumn
            // 
            this.urlDataGridViewTextBoxColumn.DataPropertyName = "url";
            this.urlDataGridViewTextBoxColumn.HeaderText = "Url";
            this.urlDataGridViewTextBoxColumn.Name = "urlDataGridViewTextBoxColumn";
            this.urlDataGridViewTextBoxColumn.Width = 150;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(3, 438);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1068, 40);
            this.panel4.TabIndex = 0;
            // 
            // grd_publications
            // 
            this.grd_publications.AllowUserToResizeRows = false;
            this.grd_publications.AutoGenerateColumns = false;
            this.grd_publications.BackgroundColor = System.Drawing.Color.White;
            this.grd_publications.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd_publications.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codeDataGridViewTextBoxColumn,
            this.titleDataGridViewTextBoxColumn1,
            this.yearDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn,
            this.urlDataGridViewTextBoxColumn1,
            this.pdfDataGridViewTextBoxColumn,
            this.bibtexDataGridViewTextBoxColumn,
            this.contributorsDataGridViewTextBoxColumn,
            this.publicationsPageVisibleDataGridViewCheckBoxColumn,
            this.peoplePageVisibleDataGridViewCheckBoxColumn});
            this.grd_publications.DataSource = this.publicationBindingSource;
            this.grd_publications.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grd_publications.Location = new System.Drawing.Point(3, 3);
            this.grd_publications.Name = "grd_publications";
            this.grd_publications.RowHeadersWidth = 20;
            this.grd_publications.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grd_publications.RowTemplate.Height = 24;
            this.grd_publications.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grd_publications.Size = new System.Drawing.Size(1068, 435);
            this.grd_publications.TabIndex = 1;
            // 
            // publicationBindingSource
            // 
            this.publicationBindingSource.DataSource = typeof(ImagingLab.CPanel.Publication);
            // 
            // codeDataGridViewTextBoxColumn
            // 
            this.codeDataGridViewTextBoxColumn.DataPropertyName = "code";
            this.codeDataGridViewTextBoxColumn.HeaderText = "Code";
            this.codeDataGridViewTextBoxColumn.Name = "codeDataGridViewTextBoxColumn";
            this.codeDataGridViewTextBoxColumn.Width = 50;
            // 
            // titleDataGridViewTextBoxColumn1
            // 
            this.titleDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.titleDataGridViewTextBoxColumn1.DataPropertyName = "title";
            this.titleDataGridViewTextBoxColumn1.HeaderText = "Title";
            this.titleDataGridViewTextBoxColumn1.MinimumWidth = 150;
            this.titleDataGridViewTextBoxColumn1.Name = "titleDataGridViewTextBoxColumn1";
            // 
            // yearDataGridViewTextBoxColumn
            // 
            this.yearDataGridViewTextBoxColumn.DataPropertyName = "year";
            this.yearDataGridViewTextBoxColumn.HeaderText = "Year";
            this.yearDataGridViewTextBoxColumn.Name = "yearDataGridViewTextBoxColumn";
            this.yearDataGridViewTextBoxColumn.Width = 50;
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "Type";
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            this.typeDataGridViewTextBoxColumn.Width = 120;
            // 
            // urlDataGridViewTextBoxColumn1
            // 
            this.urlDataGridViewTextBoxColumn1.DataPropertyName = "url";
            this.urlDataGridViewTextBoxColumn1.HeaderText = "Url";
            this.urlDataGridViewTextBoxColumn1.Name = "urlDataGridViewTextBoxColumn1";
            this.urlDataGridViewTextBoxColumn1.Width = 120;
            // 
            // pdfDataGridViewTextBoxColumn
            // 
            this.pdfDataGridViewTextBoxColumn.DataPropertyName = "pdf";
            this.pdfDataGridViewTextBoxColumn.HeaderText = "PDF";
            this.pdfDataGridViewTextBoxColumn.Name = "pdfDataGridViewTextBoxColumn";
            this.pdfDataGridViewTextBoxColumn.Width = 120;
            // 
            // bibtexDataGridViewTextBoxColumn
            // 
            this.bibtexDataGridViewTextBoxColumn.DataPropertyName = "bibtex";
            this.bibtexDataGridViewTextBoxColumn.HeaderText = "BibTex";
            this.bibtexDataGridViewTextBoxColumn.Name = "bibtexDataGridViewTextBoxColumn";
            // 
            // contributorsDataGridViewTextBoxColumn
            // 
            this.contributorsDataGridViewTextBoxColumn.DataPropertyName = "contributors";
            this.contributorsDataGridViewTextBoxColumn.HeaderText = "Contributors";
            this.contributorsDataGridViewTextBoxColumn.Name = "contributorsDataGridViewTextBoxColumn";
            // 
            // publicationsPageVisibleDataGridViewCheckBoxColumn
            // 
            this.publicationsPageVisibleDataGridViewCheckBoxColumn.DataPropertyName = "publicationsPageVisible";
            this.publicationsPageVisibleDataGridViewCheckBoxColumn.HeaderText = "Visible";
            this.publicationsPageVisibleDataGridViewCheckBoxColumn.Name = "publicationsPageVisibleDataGridViewCheckBoxColumn";
            this.publicationsPageVisibleDataGridViewCheckBoxColumn.Width = 60;
            // 
            // peoplePageVisibleDataGridViewCheckBoxColumn
            // 
            this.peoplePageVisibleDataGridViewCheckBoxColumn.DataPropertyName = "peoplePageVisible";
            this.peoplePageVisibleDataGridViewCheckBoxColumn.HeaderText = "People Visible";
            this.peoplePageVisibleDataGridViewCheckBoxColumn.Name = "peoplePageVisibleDataGridViewCheckBoxColumn";
            this.peoplePageVisibleDataGridViewCheckBoxColumn.Width = 115;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.FillWeight = 20F;
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 120;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.FillWeight = 20F;
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.MinimumWidth = 120;
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // positionDataGridViewTextBoxColumn
            // 
            this.positionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.positionDataGridViewTextBoxColumn.DataPropertyName = "position";
            this.positionDataGridViewTextBoxColumn.FillWeight = 20F;
            this.positionDataGridViewTextBoxColumn.HeaderText = "Position";
            this.positionDataGridViewTextBoxColumn.MinimumWidth = 100;
            this.positionDataGridViewTextBoxColumn.Name = "positionDataGridViewTextBoxColumn";
            // 
            // educationDataGridViewTextBoxColumn
            // 
            this.educationDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.educationDataGridViewTextBoxColumn.DataPropertyName = "education";
            this.educationDataGridViewTextBoxColumn.FillWeight = 20F;
            this.educationDataGridViewTextBoxColumn.HeaderText = "Education";
            this.educationDataGridViewTextBoxColumn.MinimumWidth = 50;
            this.educationDataGridViewTextBoxColumn.Name = "educationDataGridViewTextBoxColumn";
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "description";
            this.descriptionDataGridViewTextBoxColumn.FillWeight = 20F;
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.MinimumWidth = 50;
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            // 
            // startDataGridViewTextBoxColumn
            // 
            this.startDataGridViewTextBoxColumn.DataPropertyName = "start";
            this.startDataGridViewTextBoxColumn.HeaderText = "Start";
            this.startDataGridViewTextBoxColumn.Name = "startDataGridViewTextBoxColumn";
            this.startDataGridViewTextBoxColumn.Width = 120;
            // 
            // endDataGridViewTextBoxColumn
            // 
            this.endDataGridViewTextBoxColumn.DataPropertyName = "end";
            this.endDataGridViewTextBoxColumn.HeaderText = "End";
            this.endDataGridViewTextBoxColumn.Name = "endDataGridViewTextBoxColumn";
            this.endDataGridViewTextBoxColumn.Width = 120;
            // 
            // photoDataGridViewTextBoxColumn
            // 
            this.photoDataGridViewTextBoxColumn.DataPropertyName = "photo";
            this.photoDataGridViewTextBoxColumn.HeaderText = "Photo";
            this.photoDataGridViewTextBoxColumn.Name = "photoDataGridViewTextBoxColumn";
            this.photoDataGridViewTextBoxColumn.Width = 95;
            // 
            // alumniDataGridViewCheckBoxColumn
            // 
            this.alumniDataGridViewCheckBoxColumn.DataPropertyName = "alumni";
            this.alumniDataGridViewCheckBoxColumn.HeaderText = "Alumni";
            this.alumniDataGridViewCheckBoxColumn.Name = "alumniDataGridViewCheckBoxColumn";
            this.alumniDataGridViewCheckBoxColumn.Width = 57;
            // 
            // visibleDataGridViewCheckBoxColumn
            // 
            this.visibleDataGridViewCheckBoxColumn.DataPropertyName = "visible";
            this.visibleDataGridViewCheckBoxColumn.HeaderText = "Visible";
            this.visibleDataGridViewCheckBoxColumn.Name = "visibleDataGridViewCheckBoxColumn";
            this.visibleDataGridViewCheckBoxColumn.Width = 57;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1082, 553);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(500, 400);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ImagingLab Control Panel";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage_home.ResumeLayout(false);
            this.tabPage_home.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage_publication.ResumeLayout(false);
            this.tabPage_people.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grd_people)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.peopleBindingSource)).EndInit();
            this.tabPage_teaching.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grd_teaching)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teachingBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grd_publications)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.publicationBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn semesterDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn universityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn urlDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView grd_publications;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.BindingSource publicationBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn urlDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn pdfDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bibtexDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contributorsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn publicationsPageVisibleDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn peoplePageVisibleDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn positionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn educationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn photoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn alumniDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn visibleDataGridViewCheckBoxColumn;
    }
}

