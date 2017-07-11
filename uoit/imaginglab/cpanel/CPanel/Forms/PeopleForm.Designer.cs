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
            this.label8 = new System.Windows.Forms.Label();
            this.pic_photo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic_photo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(93, 12);
            this.txt_name.Name = "txt_name";
            this.txt_name.Required = true;
            this.txt_name.Size = new System.Drawing.Size(316, 22);
            this.txt_name.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Email:";
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(93, 40);
            this.txt_email.Name = "txt_email";
            this.txt_email.Required = true;
            this.txt_email.Size = new System.Drawing.Size(316, 22);
            this.txt_email.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Position:";
            // 
            // txt_position
            // 
            this.txt_position.Location = new System.Drawing.Point(93, 68);
            this.txt_position.Name = "txt_position";
            this.txt_position.Required = true;
            this.txt_position.Size = new System.Drawing.Size(316, 22);
            this.txt_position.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Education:";
            // 
            // txt_education
            // 
            this.txt_education.Location = new System.Drawing.Point(93, 96);
            this.txt_education.Name = "txt_education";
            this.txt_education.Required = true;
            this.txt_education.Size = new System.Drawing.Size(316, 22);
            this.txt_education.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 127);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Start Date:";
            // 
            // txt_start
            // 
            this.txt_start.Location = new System.Drawing.Point(93, 124);
            this.txt_start.Name = "txt_start";
            this.txt_start.Size = new System.Drawing.Size(316, 22);
            this.txt_start.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 183);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Description:";
            // 
            // txt_description
            // 
            this.txt_description.AcceptsReturn = true;
            this.txt_description.Location = new System.Drawing.Point(93, 180);
            this.txt_description.Multiline = true;
            this.txt_description.Name = "txt_description";
            this.txt_description.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_description.Size = new System.Drawing.Size(316, 96);
            this.txt_description.TabIndex = 7;
            // 
            // button_save
            // 
            this.button_save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_save.Location = new System.Drawing.Point(492, 321);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(90, 27);
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
            this.button_cancel.Location = new System.Drawing.Point(396, 321);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(90, 27);
            this.button_cancel.TabIndex = 10;
            this.button_cancel.Text = "Cancel";
            this.button_cancel.UseVisualStyleBackColor = true;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // chk_visible
            // 
            this.chk_visible.AutoSize = true;
            this.chk_visible.Location = new System.Drawing.Point(93, 282);
            this.chk_visible.Name = "chk_visible";
            this.chk_visible.Size = new System.Drawing.Size(71, 21);
            this.chk_visible.TabIndex = 8;
            this.chk_visible.Text = "Visible";
            this.chk_visible.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "End Date:";
            // 
            // txt_end
            // 
            this.txt_end.Location = new System.Drawing.Point(93, 152);
            this.txt_end.Name = "txt_end";
            this.txt_end.Size = new System.Drawing.Size(316, 22);
            this.txt_end.TabIndex = 6;
            // 
            // chk_alumnus
            // 
            this.chk_alumnus.AutoSize = true;
            this.chk_alumnus.Location = new System.Drawing.Point(93, 309);
            this.chk_alumnus.Name = "chk_alumnus";
            this.chk_alumnus.Size = new System.Drawing.Size(84, 21);
            this.chk_alumnus.TabIndex = 9;
            this.chk_alumnus.Text = "Alumnus";
            this.chk_alumnus.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label8.Location = new System.Drawing.Point(450, 178);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 15);
            this.label8.TabIndex = 16;
            this.label8.Text = "(click to change)";
            // 
            // pic_photo
            // 
            this.pic_photo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pic_photo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_photo.Image = global::ImagingLab.CPanel.Properties.Resources.noimage;
            this.pic_photo.Location = new System.Drawing.Point(418, 12);
            this.pic_photo.Name = "pic_photo";
            this.pic_photo.Size = new System.Drawing.Size(162, 162);
            this.pic_photo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_photo.TabIndex = 15;
            this.pic_photo.TabStop = false;
            // 
            // PeopleForm
            // 
            this.AcceptButton = this.button_save;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button_cancel;
            this.ClientSize = new System.Drawing.Size(594, 360);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.chk_alumnus);
            this.Controls.Add(this.chk_visible);
            this.Controls.Add(this.pic_photo);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.button_cancel);
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
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
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
        private System.Windows.Forms.Label label8;
    }
}