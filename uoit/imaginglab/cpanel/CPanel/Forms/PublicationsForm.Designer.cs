namespace ImagingLab.CPanel
{
    partial class PublicationsForm
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
            Publication = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PublicationsForm));
            this.button_save = new System.Windows.Forms.Button();
            this.button_cancel = new System.Windows.Forms.Button();
            this.txt_code = new ImagingLab.CPanel.CPanelTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmb_type = new System.Windows.Forms.ComboBox();
            this.txt_url = new ImagingLab.CPanel.CPanelTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_pdf = new ImagingLab.CPanel.CPanelTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_authors = new ImagingLab.CPanel.CPanelTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_title = new ImagingLab.CPanel.CPanelTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.chk_visible = new System.Windows.Forms.CheckBox();
            this.chk_peopleVisible = new System.Windows.Forms.CheckBox();
            this.num_year = new System.Windows.Forms.NumericUpDown();
            this.txt_bibtex = new ImagingLab.CPanel.CPanelTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pic_cancel = new System.Windows.Forms.PictureBox();
            this.pic_upload = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.grd_people = new System.Windows.Forms.DataGridView();
            this.chekedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.peoplePublicationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.num_year)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_cancel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_upload)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd_people)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.peoplePublicationBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button_save
            // 
            this.button_save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_save.Location = new System.Drawing.Point(488, 564);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(90, 27);
            this.button_save.TabIndex = 12;
            this.button_save.Text = "Save";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // button_cancel
            // 
            this.button_cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_cancel.Location = new System.Drawing.Point(392, 564);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(90, 27);
            this.button_cancel.TabIndex = 11;
            this.button_cancel.Text = "Cancel";
            this.button_cancel.UseVisualStyleBackColor = true;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // txt_code
            // 
            this.txt_code.Location = new System.Drawing.Point(107, 12);
            this.txt_code.Name = "txt_code";
            this.txt_code.Size = new System.Drawing.Size(78, 22);
            this.txt_code.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Code:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Year:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Type:";
            // 
            // cmb_type
            // 
            this.cmb_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_type.FormattingEnabled = true;
            this.cmb_type.Location = new System.Drawing.Point(107, 71);
            this.cmb_type.Name = "cmb_type";
            this.cmb_type.Size = new System.Drawing.Size(157, 24);
            this.cmb_type.TabIndex = 3;
            // 
            // txt_url
            // 
            this.txt_url.Location = new System.Drawing.Point(107, 101);
            this.txt_url.Name = "txt_url";
            this.txt_url.Size = new System.Drawing.Size(463, 22);
            this.txt_url.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "URL:";
            // 
            // txt_pdf
            // 
            this.txt_pdf.Location = new System.Drawing.Point(107, 129);
            this.txt_pdf.Name = "txt_pdf";
            this.txt_pdf.ReadOnly = true;
            this.txt_pdf.Size = new System.Drawing.Size(405, 22);
            this.txt_pdf.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "PDF:";
            // 
            // txt_authors
            // 
            this.txt_authors.Location = new System.Drawing.Point(107, 157);
            this.txt_authors.Name = "txt_authors";
            this.txt_authors.Required = true;
            this.txt_authors.Size = new System.Drawing.Size(463, 22);
            this.txt_authors.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Authors:";
            // 
            // txt_title
            // 
            this.txt_title.AcceptsReturn = true;
            this.txt_title.Location = new System.Drawing.Point(107, 185);
            this.txt_title.Multiline = true;
            this.txt_title.Name = "txt_title";
            this.txt_title.Required = true;
            this.txt_title.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_title.Size = new System.Drawing.Size(463, 60);
            this.txt_title.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 188);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 17);
            this.label7.TabIndex = 11;
            this.label7.Text = "Title:";
            // 
            // chk_visible
            // 
            this.chk_visible.AutoSize = true;
            this.chk_visible.Location = new System.Drawing.Point(107, 517);
            this.chk_visible.Name = "chk_visible";
            this.chk_visible.Size = new System.Drawing.Size(71, 21);
            this.chk_visible.TabIndex = 9;
            this.chk_visible.Text = "Visible";
            this.chk_visible.UseVisualStyleBackColor = true;
            // 
            // chk_peopleVisible
            // 
            this.chk_peopleVisible.AutoSize = true;
            this.chk_peopleVisible.Location = new System.Drawing.Point(107, 544);
            this.chk_peopleVisible.Name = "chk_peopleVisible";
            this.chk_peopleVisible.Size = new System.Drawing.Size(169, 21);
            this.chk_peopleVisible.TabIndex = 10;
            this.chk_peopleVisible.Text = "Visible in people page";
            this.chk_peopleVisible.UseVisualStyleBackColor = true;
            // 
            // num_year
            // 
            this.num_year.Location = new System.Drawing.Point(107, 43);
            this.num_year.Maximum = new decimal(new int[] {
            2050,
            0,
            0,
            0});
            this.num_year.Minimum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.num_year.Name = "num_year";
            this.num_year.Size = new System.Drawing.Size(78, 22);
            this.num_year.TabIndex = 2;
            this.num_year.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            // 
            // txt_bibtex
            // 
            this.txt_bibtex.AcceptsReturn = true;
            this.txt_bibtex.AcceptsTab = true;
            this.txt_bibtex.Location = new System.Drawing.Point(107, 251);
            this.txt_bibtex.Multiline = true;
            this.txt_bibtex.Name = "txt_bibtex";
            this.txt_bibtex.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txt_bibtex.Size = new System.Drawing.Size(463, 104);
            this.txt_bibtex.TabIndex = 8;
            this.txt_bibtex.WordWrap = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 254);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 17);
            this.label8.TabIndex = 11;
            this.label8.Text = "BibTex:";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "PDF files|*.pdf|All files|*.*";
            // 
            // pic_cancel
            // 
            this.pic_cancel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pic_cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_cancel.Image = ((System.Drawing.Image)(resources.GetObject("pic_cancel.Image")));
            this.pic_cancel.Location = new System.Drawing.Point(547, 129);
            this.pic_cancel.Name = "pic_cancel";
            this.pic_cancel.Size = new System.Drawing.Size(23, 23);
            this.pic_cancel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_cancel.TabIndex = 13;
            this.pic_cancel.TabStop = false;
            this.toolTip1.SetToolTip(this.pic_cancel, "Remove the PDF file.");
            this.pic_cancel.Click += new System.EventHandler(this.pic_cancel_Click);
            // 
            // pic_upload
            // 
            this.pic_upload.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pic_upload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_upload.Image = ((System.Drawing.Image)(resources.GetObject("pic_upload.Image")));
            this.pic_upload.Location = new System.Drawing.Point(518, 129);
            this.pic_upload.Name = "pic_upload";
            this.pic_upload.Size = new System.Drawing.Size(23, 23);
            this.pic_upload.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pic_upload.TabIndex = 13;
            this.pic_upload.TabStop = false;
            this.toolTip1.SetToolTip(this.pic_upload, "Select a PDF file.");
            this.pic_upload.Click += new System.EventHandler(this.pic_upload_Click);
            // 
            // grd_people
            // 
            this.grd_people.AllowUserToAddRows = false;
            this.grd_people.AllowUserToDeleteRows = false;
            this.grd_people.AllowUserToResizeColumns = false;
            this.grd_people.AllowUserToResizeRows = false;
            this.grd_people.AutoGenerateColumns = false;
            this.grd_people.BackgroundColor = System.Drawing.Color.White;
            this.grd_people.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd_people.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.chekedDataGridViewCheckBoxColumn,
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn});
            this.grd_people.DataSource = this.peoplePublicationBindingSource;
            this.grd_people.Location = new System.Drawing.Point(107, 361);
            this.grd_people.MultiSelect = false;
            this.grd_people.Name = "grd_people";
            this.grd_people.RowHeadersVisible = false;
            this.grd_people.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grd_people.RowTemplate.Height = 24;
            this.grd_people.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grd_people.Size = new System.Drawing.Size(463, 150);
            this.grd_people.TabIndex = 14;
            // 
            // chekedDataGridViewCheckBoxColumn
            // 
            this.chekedDataGridViewCheckBoxColumn.DataPropertyName = "selected";
            this.chekedDataGridViewCheckBoxColumn.HeaderText = "Select";
            this.chekedDataGridViewCheckBoxColumn.Name = "chekedDataGridViewCheckBoxColumn";
            this.chekedDataGridViewCheckBoxColumn.Width = 70;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // peoplePublicationBindingSource
            // 
            this.peoplePublicationBindingSource.DataSource = typeof(ImagingLab.CPanel.PeoplePublication);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 361);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 17);
            this.label9.TabIndex = 11;
            this.label9.Text = "People:";
            // 
            // PublicationsForm
            // 
            this.AcceptButton = this.button_save;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button_cancel;
            this.ClientSize = new System.Drawing.Size(590, 603);
            this.Controls.Add(this.grd_people);
            this.Controls.Add(this.pic_cancel);
            this.Controls.Add(this.pic_upload);
            this.Controls.Add(this.num_year);
            this.Controls.Add(this.chk_peopleVisible);
            this.Controls.Add(this.chk_visible);
            this.Controls.Add(this.cmb_type);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_bibtex);
            this.Controls.Add(this.txt_title);
            this.Controls.Add(this.txt_authors);
            this.Controls.Add(this.txt_pdf);
            this.Controls.Add(this.txt_url);
            this.Controls.Add(this.txt_code);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.button_cancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PublicationsForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Publications";
            ((System.ComponentModel.ISupportInitialize)(this.num_year)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_cancel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_upload)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd_people)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.peoplePublicationBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.Button button_cancel;
        private CPanelTextBox txt_code;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmb_type;
        private CPanelTextBox txt_url;
        private System.Windows.Forms.Label label4;
        private CPanelTextBox txt_pdf;
        private System.Windows.Forms.Label label5;
        private CPanelTextBox txt_authors;
        private System.Windows.Forms.Label label6;
        private CPanelTextBox txt_title;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox chk_visible;
        private System.Windows.Forms.CheckBox chk_peopleVisible;
        private System.Windows.Forms.NumericUpDown num_year;
        private CPanelTextBox txt_bibtex;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox pic_cancel;
        private System.Windows.Forms.PictureBox pic_upload;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.DataGridView grd_people;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.BindingSource peoplePublicationBindingSource;
        private System.Windows.Forms.DataGridViewCheckBoxColumn chekedDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
    }
}