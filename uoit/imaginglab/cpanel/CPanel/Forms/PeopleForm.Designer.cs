namespace ImagingLab.CPanel
{
    partial class PeopleForm
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
            People = null;

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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_name = new ImagingLab.CPanel.CPanelTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_email = new ImagingLab.CPanel.CPanelTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_position = new ImagingLab.CPanel.CPanelTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_education = new ImagingLab.CPanel.CPanelTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_start = new ImagingLab.CPanel.CPanelTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_description = new ImagingLab.CPanel.CPanelTextBox();
            this.button_save = new System.Windows.Forms.Button();
            this.button_cancel = new System.Windows.Forms.Button();
            this.chk_visible = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_end = new ImagingLab.CPanel.CPanelTextBox();
            this.chk_alumnus = new System.Windows.Forms.CheckBox();
            this.label_image = new System.Windows.Forms.Label();
            this.pic_photo = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_title = new ImagingLab.CPanel.CPanelTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_research = new ImagingLab.CPanel.CPanelTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic_photo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(70, 10);
            this.txt_name.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_name.Name = "txt_name";
            this.txt_name.Required = true;
            this.txt_name.Size = new System.Drawing.Size(238, 20);
            this.txt_name.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 35);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Email:";
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(70, 32);
            this.txt_email.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_email.Name = "txt_email";
            this.txt_email.Required = true;
            this.txt_email.Size = new System.Drawing.Size(238, 20);
            this.txt_email.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 80);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Position:";
            // 
            // txt_position
            // 
            this.txt_position.Location = new System.Drawing.Point(70, 78);
            this.txt_position.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_position.Name = "txt_position";
            this.txt_position.Required = true;
            this.txt_position.Size = new System.Drawing.Size(238, 20);
            this.txt_position.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 103);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Education:";
            // 
            // txt_education
            // 
            this.txt_education.Location = new System.Drawing.Point(70, 101);
            this.txt_education.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_education.Name = "txt_education";
            this.txt_education.Size = new System.Drawing.Size(238, 20);
            this.txt_education.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 126);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Start Date:";
            // 
            // txt_start
            // 
            this.txt_start.Location = new System.Drawing.Point(70, 124);
            this.txt_start.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_start.Name = "txt_start";
            this.txt_start.Size = new System.Drawing.Size(238, 20);
            this.txt_start.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 238);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Description:";
            // 
            // txt_description
            // 
            this.txt_description.AcceptsReturn = true;
            this.txt_description.Location = new System.Drawing.Point(70, 236);
            this.txt_description.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_description.Multiline = true;
            this.txt_description.Name = "txt_description";
            this.txt_description.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_description.Size = new System.Drawing.Size(366, 115);
            this.txt_description.TabIndex = 7;
            // 
            // button_save
            // 
            this.button_save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_save.Location = new System.Drawing.Point(368, 390);
            this.button_save.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(68, 22);
            this.button_save.TabIndex = 11;
            this.button_save.Text = "Save";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // button_cancel
            // 
            this.button_cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_cancel.Location = new System.Drawing.Point(296, 390);
            this.button_cancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(68, 22);
            this.button_cancel.TabIndex = 10;
            this.button_cancel.Text = "Cancel";
            this.button_cancel.UseVisualStyleBackColor = true;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // chk_visible
            // 
            this.chk_visible.AutoSize = true;
            this.chk_visible.Location = new System.Drawing.Point(70, 355);
            this.chk_visible.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chk_visible.Name = "chk_visible";
            this.chk_visible.Size = new System.Drawing.Size(56, 17);
            this.chk_visible.TabIndex = 8;
            this.chk_visible.Text = "Visible";
            this.chk_visible.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 149);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "End Date:";
            // 
            // txt_end
            // 
            this.txt_end.Location = new System.Drawing.Point(70, 146);
            this.txt_end.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_end.Name = "txt_end";
            this.txt_end.Size = new System.Drawing.Size(238, 20);
            this.txt_end.TabIndex = 6;
            // 
            // chk_alumnus
            // 
            this.chk_alumnus.AutoSize = true;
            this.chk_alumnus.Location = new System.Drawing.Point(70, 377);
            this.chk_alumnus.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chk_alumnus.Name = "chk_alumnus";
            this.chk_alumnus.Size = new System.Drawing.Size(66, 17);
            this.chk_alumnus.TabIndex = 9;
            this.chk_alumnus.Text = "Alumnus";
            this.chk_alumnus.UseVisualStyleBackColor = true;
            // 
            // label_image
            // 
            this.label_image.AutoSize = true;
            this.label_image.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_image.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label_image.Location = new System.Drawing.Point(338, 145);
            this.label_image.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_image.Name = "label_image";
            this.label_image.Size = new System.Drawing.Size(82, 13);
            this.label_image.TabIndex = 16;
            this.label_image.Text = "(click to change)";
            this.label_image.Click += new System.EventHandler(this.label_image_Click);
            // 
            // pic_photo
            // 
            this.pic_photo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pic_photo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_photo.Image = global::ImagingLab.CPanel.Properties.Resources.noimage;
            this.pic_photo.Location = new System.Drawing.Point(314, 10);
            this.pic_photo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pic_photo.Name = "pic_photo";
            this.pic_photo.Size = new System.Drawing.Size(122, 132);
            this.pic_photo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_photo.TabIndex = 15;
            this.pic_photo.TabStop = false;
            this.pic_photo.Click += new System.EventHandler(this.pic_photo_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "Images|*.jpg;*.jpeg;*.png;*.gif;*.bmp;|All files|*.*";
            this.openFileDialog1.InitialDirectory = "/data";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 58);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Title:";
            // 
            // txt_title
            // 
            this.txt_title.Location = new System.Drawing.Point(70, 55);
            this.txt_title.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_title.Name = "txt_title";
            this.txt_title.Required = true;
            this.txt_title.Size = new System.Drawing.Size(238, 20);
            this.txt_title.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 171);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Research:";
            // 
            // txt_research
            // 
            this.txt_research.AcceptsReturn = true;
            this.txt_research.Location = new System.Drawing.Point(70, 169);
            this.txt_research.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_research.Multiline = true;
            this.txt_research.Name = "txt_research";
            this.txt_research.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_research.Size = new System.Drawing.Size(366, 62);
            this.txt_research.TabIndex = 7;
            // 
            // PeopleForm
            // 
            this.AcceptButton = this.button_save;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button_cancel;
            this.ClientSize = new System.Drawing.Size(454, 423);
            this.Controls.Add(this.label_image);
            this.Controls.Add(this.chk_alumnus);
            this.Controls.Add(this.chk_visible);
            this.Controls.Add(this.pic_photo);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.txt_research);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_description);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_end);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_start);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_education);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_position);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_title);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PeopleForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "People";
            ((System.ComponentModel.ISupportInitialize)(this.pic_photo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private CPanelTextBox txt_name;
        private System.Windows.Forms.Label label2;
        private CPanelTextBox txt_email;
        private System.Windows.Forms.Label label3;
        private CPanelTextBox txt_position;
        private System.Windows.Forms.Label label4;
        private CPanelTextBox txt_education;
        private System.Windows.Forms.Label label6;
        private CPanelTextBox txt_start;
        private System.Windows.Forms.Label label7;
        private CPanelTextBox txt_description;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.PictureBox pic_photo;
        private System.Windows.Forms.CheckBox chk_visible;
        private System.Windows.Forms.Label label5;
        private CPanelTextBox txt_end;
        private System.Windows.Forms.CheckBox chk_alumnus;
        private System.Windows.Forms.Label label_image;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label8;
        private CPanelTextBox txt_title;
        private System.Windows.Forms.Label label9;
        private CPanelTextBox txt_research;
    }
}