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
            this.txt_contributors = new ImagingLab.CPanel.CPanelTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_title = new ImagingLab.CPanel.CPanelTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.chk_visible = new System.Windows.Forms.CheckBox();
            this.chk_peopleVisible = new System.Windows.Forms.CheckBox();
            this.num_year = new System.Windows.Forms.NumericUpDown();
            this.txt_bibtex = new ImagingLab.CPanel.CPanelTextBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.num_year)).BeginInit();
            this.SuspendLayout();
            // 
            // button_save
            // 
            this.button_save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_save.Location = new System.Drawing.Point(530, 440);
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
            this.button_cancel.Location = new System.Drawing.Point(434, 440);
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
            this.txt_pdf.Size = new System.Drawing.Size(463, 22);
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
            // txt_contributors
            // 
            this.txt_contributors.Location = new System.Drawing.Point(107, 157);
            this.txt_contributors.Name = "txt_contributors";
            this.txt_contributors.Required = true;
            this.txt_contributors.Size = new System.Drawing.Size(463, 22);
            this.txt_contributors.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Contributors:";
            // 
            // txt_title
            // 
            this.txt_title.AcceptsReturn = true;
            this.txt_title.AcceptsTab = true;
            this.txt_title.Location = new System.Drawing.Point(107, 185);
            this.txt_title.Multiline = true;
            this.txt_title.Name = "txt_title";
            this.txt_title.Required = true;
            this.txt_title.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_title.Size = new System.Drawing.Size(463, 63);
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
            this.chk_visible.Location = new System.Drawing.Point(107, 383);
            this.chk_visible.Name = "chk_visible";
            this.chk_visible.Size = new System.Drawing.Size(71, 21);
            this.chk_visible.TabIndex = 9;
            this.chk_visible.Text = "Visible";
            this.chk_visible.UseVisualStyleBackColor = true;
            // 
            // chk_peopleVisible
            // 
            this.chk_peopleVisible.AutoSize = true;
            this.chk_peopleVisible.Location = new System.Drawing.Point(107, 410);
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
            this.txt_bibtex.Location = new System.Drawing.Point(107, 254);
            this.txt_bibtex.Multiline = true;
            this.txt_bibtex.Name = "txt_bibtex";
            this.txt_bibtex.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txt_bibtex.Size = new System.Drawing.Size(463, 123);
            this.txt_bibtex.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 257);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 17);
            this.label8.TabIndex = 11;
            this.label8.Text = "BibTex:";
            // 
            // PublicationsForm
            // 
            this.AcceptButton = this.button_save;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button_cancel;
            this.ClientSize = new System.Drawing.Size(632, 479);
            this.Controls.Add(this.num_year);
            this.Controls.Add(this.chk_peopleVisible);
            this.Controls.Add(this.chk_visible);
            this.Controls.Add(this.cmb_type);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_bibtex);
            this.Controls.Add(this.txt_title);
            this.Controls.Add(this.txt_contributors);
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
        private CPanelTextBox txt_contributors;
        private System.Windows.Forms.Label label6;
        private CPanelTextBox txt_title;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox chk_visible;
        private System.Windows.Forms.CheckBox chk_peopleVisible;
        private System.Windows.Forms.NumericUpDown num_year;
        private CPanelTextBox txt_bibtex;
        private System.Windows.Forms.Label label8;
    }
}