namespace ImagingLab.CPanel
{
    partial class CredentialsForm
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
            this.button_upload = new System.Windows.Forms.Button();
            this.button_cancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.chk_savePassword = new System.Windows.Forms.CheckBox();
            this.panel_container = new System.Windows.Forms.Panel();
            this.txt_username = new ImagingLab.CPanel.CPanelTextBox();
            this.txt_password = new ImagingLab.CPanel.CPanelTextBox();
            this.panel_container.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_upload
            // 
            this.button_upload.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_upload.Location = new System.Drawing.Point(289, 112);
            this.button_upload.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_upload.Name = "button_upload";
            this.button_upload.Size = new System.Drawing.Size(91, 27);
            this.button_upload.TabIndex = 13;
            this.button_upload.Text = "Upload";
            this.button_upload.UseVisualStyleBackColor = true;
            this.button_upload.Click += new System.EventHandler(this.button_upload_Click);
            // 
            // button_cancel
            // 
            this.button_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_cancel.Location = new System.Drawing.Point(183, 112);
            this.button_cancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(91, 27);
            this.button_cancel.TabIndex = 12;
            this.button_cancel.Text = "Cancel";
            this.button_cancel.UseVisualStyleBackColor = true;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "Username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "Password:";
            // 
            // chk_savePassword
            // 
            this.chk_savePassword.AutoSize = true;
            this.chk_savePassword.Location = new System.Drawing.Point(100, 73);
            this.chk_savePassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chk_savePassword.Name = "chk_savePassword";
            this.chk_savePassword.Size = new System.Drawing.Size(126, 21);
            this.chk_savePassword.TabIndex = 16;
            this.chk_savePassword.Text = "Save password";
            this.chk_savePassword.UseVisualStyleBackColor = true;
            // 
            // panel_container
            // 
            this.panel_container.Controls.Add(this.txt_username);
            this.panel_container.Controls.Add(this.chk_savePassword);
            this.panel_container.Controls.Add(this.button_cancel);
            this.panel_container.Controls.Add(this.txt_password);
            this.panel_container.Controls.Add(this.button_upload);
            this.panel_container.Controls.Add(this.label2);
            this.panel_container.Controls.Add(this.label1);
            this.panel_container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_container.Location = new System.Drawing.Point(0, 0);
            this.panel_container.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_container.Name = "panel_container";
            this.panel_container.Size = new System.Drawing.Size(404, 150);
            this.panel_container.TabIndex = 17;
            // 
            // txt_username
            // 
            this.txt_username.Location = new System.Drawing.Point(100, 16);
            this.txt_username.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_username.Name = "txt_username";
            this.txt_username.Required = true;
            this.txt_username.Size = new System.Drawing.Size(280, 22);
            this.txt_username.TabIndex = 15;
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(100, 44);
            this.txt_password.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_password.Name = "txt_password";
            this.txt_password.Required = true;
            this.txt_password.Size = new System.Drawing.Size(280, 22);
            this.txt_password.TabIndex = 15;
            this.txt_password.UseSystemPasswordChar = true;
            // 
            // CredentialsForm
            // 
            this.AcceptButton = this.button_upload;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button_cancel;
            this.ClientSize = new System.Drawing.Size(404, 150);
            this.Controls.Add(this.panel_container);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CredentialsForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Server Credentials";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CredentialsForm_FormClosing);
            this.panel_container.ResumeLayout(false);
            this.panel_container.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_upload;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private CPanelTextBox txt_username;
        private CPanelTextBox txt_password;
        private System.Windows.Forms.CheckBox chk_savePassword;
        private System.Windows.Forms.Panel panel_container;
    }
}