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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_publish = new System.Windows.Forms.Button();
            this.button_save = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage_Home);
            this.tabControl1.Controls.Add(this.tabPage_People);
            this.tabControl1.Controls.Add(this.tabPage_Publication);
            this.tabControl1.Controls.Add(this.tabPage_Teaching);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.HotTrack = true;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(832, 509);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage_Home
            // 
            this.tabPage_Home.BackColor = System.Drawing.Color.White;
            this.tabPage_Home.Location = new System.Drawing.Point(4, 24);
            this.tabPage_Home.Name = "tabPage_Home";
            this.tabPage_Home.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Home.Size = new System.Drawing.Size(824, 481);
            this.tabPage_Home.TabIndex = 0;
            this.tabPage_Home.Text = " HOME ";
            // 
            // tabPage_People
            // 
            this.tabPage_People.BackColor = System.Drawing.Color.White;
            this.tabPage_People.Location = new System.Drawing.Point(4, 24);
            this.tabPage_People.Name = "tabPage_People";
            this.tabPage_People.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_People.Size = new System.Drawing.Size(824, 481);
            this.tabPage_People.TabIndex = 1;
            this.tabPage_People.Text = " PEOPLE ";
            // 
            // tabPage_Publication
            // 
            this.tabPage_Publication.BackColor = System.Drawing.Color.White;
            this.tabPage_Publication.Location = new System.Drawing.Point(4, 24);
            this.tabPage_Publication.Name = "tabPage_Publication";
            this.tabPage_Publication.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Publication.Size = new System.Drawing.Size(824, 481);
            this.tabPage_Publication.TabIndex = 2;
            this.tabPage_Publication.Text = " PUBLICATION ";
            // 
            // tabPage_Teaching
            // 
            this.tabPage_Teaching.BackColor = System.Drawing.Color.White;
            this.tabPage_Teaching.Location = new System.Drawing.Point(4, 24);
            this.tabPage_Teaching.Name = "tabPage_Teaching";
            this.tabPage_Teaching.Size = new System.Drawing.Size(824, 481);
            this.tabPage_Teaching.TabIndex = 3;
            this.tabPage_Teaching.Text = " TEACHING ";
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
            this.panel1.Size = new System.Drawing.Size(832, 44);
            this.panel1.TabIndex = 1;
            // 
            // button_publish
            // 
            this.button_publish.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_publish.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_publish.Location = new System.Drawing.Point(730, 6);
            this.button_publish.Name = "button_publish";
            this.button_publish.Size = new System.Drawing.Size(90, 30);
            this.button_publish.TabIndex = 0;
            this.button_publish.Text = "Publish";
            this.button_publish.UseVisualStyleBackColor = true;
            this.button_publish.Click += new System.EventHandler(this.button_publish_Click);
            // 
            // button_save
            // 
            this.button_save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_save.Location = new System.Drawing.Point(634, 6);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(90, 30);
            this.button_save.TabIndex = 0;
            this.button_save.Text = "Save";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(832, 553);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(500, 400);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ImagingLab Control Panel";
            this.tabControl1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage_Home;
        private System.Windows.Forms.TabPage tabPage_People;
        private System.Windows.Forms.TabPage tabPage_Publication;
        private System.Windows.Forms.TabPage tabPage_Teaching;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_publish;
        private System.Windows.Forms.Button button_save;
    }
}

