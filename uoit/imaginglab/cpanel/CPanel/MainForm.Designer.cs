namespace CPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage_Home = new System.Windows.Forms.TabPage();
            this.tabPage_People = new System.Windows.Forms.TabPage();
            this.tabPage_Publication = new System.Windows.Forms.TabPage();
            this.tabPage_Teaching = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage_Home);
            this.tabControl1.Controls.Add(this.tabPage_People);
            this.tabControl1.Controls.Add(this.tabPage_Publication);
            this.tabControl1.Controls.Add(this.tabPage_Teaching);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(837, 522);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage_Home
            // 
            this.tabPage_Home.Location = new System.Drawing.Point(4, 25);
            this.tabPage_Home.Name = "tabPage_Home";
            this.tabPage_Home.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Home.Size = new System.Drawing.Size(829, 493);
            this.tabPage_Home.TabIndex = 0;
            this.tabPage_Home.Text = "Home";
            this.tabPage_Home.UseVisualStyleBackColor = true;
            // 
            // tabPage_People
            // 
            this.tabPage_People.Location = new System.Drawing.Point(4, 25);
            this.tabPage_People.Name = "tabPage_People";
            this.tabPage_People.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_People.Size = new System.Drawing.Size(829, 493);
            this.tabPage_People.TabIndex = 1;
            this.tabPage_People.Text = "People";
            this.tabPage_People.UseVisualStyleBackColor = true;
            // 
            // tabPage_Publication
            // 
            this.tabPage_Publication.Location = new System.Drawing.Point(4, 25);
            this.tabPage_Publication.Name = "tabPage_Publication";
            this.tabPage_Publication.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Publication.Size = new System.Drawing.Size(829, 493);
            this.tabPage_Publication.TabIndex = 2;
            this.tabPage_Publication.Text = "Publication";
            this.tabPage_Publication.UseVisualStyleBackColor = true;
            // 
            // tabPage_Teaching
            // 
            this.tabPage_Teaching.Location = new System.Drawing.Point(4, 25);
            this.tabPage_Teaching.Name = "tabPage_Teaching";
            this.tabPage_Teaching.Size = new System.Drawing.Size(829, 493);
            this.tabPage_Teaching.TabIndex = 3;
            this.tabPage_Teaching.Text = "Teaching";
            this.tabPage_Teaching.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 522);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ImagingLab Control Panel";
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage_Home;
        private System.Windows.Forms.TabPage tabPage_People;
        private System.Windows.Forms.TabPage tabPage_Publication;
        private System.Windows.Forms.TabPage tabPage_Teaching;
    }
}

