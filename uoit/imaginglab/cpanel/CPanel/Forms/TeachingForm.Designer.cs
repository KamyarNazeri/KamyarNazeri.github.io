namespace ImagingLab.CPanel
{
    partial class TeachingForm
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
            this.Teaching = null;
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_semester = new ImagingLab.CPanel.CPanelTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_title = new ImagingLab.CPanel.CPanelTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_description = new ImagingLab.CPanel.CPanelTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_university = new ImagingLab.CPanel.CPanelTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_url = new ImagingLab.CPanel.CPanelTextBox();
            this.chk_visible = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // button_save
            // 
            this.button_save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_save.Location = new System.Drawing.Point(394, 198);
            this.button_save.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(68, 22);
            this.button_save.TabIndex = 8;
            this.button_save.Text = "Save";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // button_cancel
            // 
            this.button_cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_cancel.Location = new System.Drawing.Point(322, 198);
            this.button_cancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(68, 22);
            this.button_cancel.TabIndex = 7;
            this.button_cancel.Text = "Cancel";
            this.button_cancel.UseVisualStyleBackColor = true;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Semester:";
            // 
            // txt_semester
            // 
            this.txt_semester.BackColor = System.Drawing.SystemColors.Window;
            this.txt_semester.Location = new System.Drawing.Point(76, 14);
            this.txt_semester.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_semester.Name = "txt_semester";
            this.txt_semester.Required = true;
            this.txt_semester.Size = new System.Drawing.Size(187, 20);
            this.txt_semester.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 84);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Title:";
            // 
            // txt_title
            // 
            this.txt_title.Location = new System.Drawing.Point(76, 82);
            this.txt_title.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_title.Name = "txt_title";
            this.txt_title.Required = true;
            this.txt_title.Size = new System.Drawing.Size(386, 20);
            this.txt_title.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 107);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Description:";
            // 
            // txt_description
            // 
            this.txt_description.AcceptsReturn = true;
            this.txt_description.Location = new System.Drawing.Point(76, 105);
            this.txt_description.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_description.Multiline = true;
            this.txt_description.Name = "txt_description";
            this.txt_description.Required = true;
            this.txt_description.Size = new System.Drawing.Size(386, 63);
            this.txt_description.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 39);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "University:";
            // 
            // txt_university
            // 
            this.txt_university.Location = new System.Drawing.Point(76, 37);
            this.txt_university.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_university.Name = "txt_university";
            this.txt_university.Required = true;
            this.txt_university.Size = new System.Drawing.Size(187, 20);
            this.txt_university.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 62);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "URL:";
            // 
            // txt_url
            // 
            this.txt_url.Location = new System.Drawing.Point(76, 59);
            this.txt_url.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_url.Name = "txt_url";
            this.txt_url.Required = true;
            this.txt_url.Size = new System.Drawing.Size(187, 20);
            this.txt_url.TabIndex = 3;
            // 
            // chk_visible
            // 
            this.chk_visible.AutoSize = true;
            this.chk_visible.Location = new System.Drawing.Point(76, 173);
            this.chk_visible.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chk_visible.Name = "chk_visible";
            this.chk_visible.Size = new System.Drawing.Size(56, 17);
            this.chk_visible.TabIndex = 6;
            this.chk_visible.Text = "Visible";
            this.chk_visible.UseVisualStyleBackColor = true;
            // 
            // TeachingForm
            // 
            this.AcceptButton = this.button_save;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button_cancel;
            this.ClientSize = new System.Drawing.Size(483, 231);
            this.Controls.Add(this.chk_visible);
            this.Controls.Add(this.txt_description);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_title);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_url);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_university);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_semester);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.button_cancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TeachingForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Teaching";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private CPanelTextBox txt_semester;
        private CPanelTextBox txt_title;
        private CPanelTextBox txt_description;
        private CPanelTextBox txt_university;
        private CPanelTextBox txt_url;
        private System.Windows.Forms.CheckBox chk_visible;
    }
}