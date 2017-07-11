using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImagingLab.CPanel
{
    public class CPanelTextBox : TextBox
    {
        public CPanelTextBox()
            : base()
        {
            this.Validating += CPanelTextBox_Validating;
        }

        protected override void OnValidating(CancelEventArgs e)
        {
            base.OnValidating(e);
        }

        void CPanelTextBox_Validating(object sender, CancelEventArgs e)
        {
            this.BackColor = SystemColors.Window;

            if (this.Required && string.IsNullOrEmpty(this.Text))
            {
                e.Cancel = true;
                this.BackColor = Color.FromArgb(255, 192, 192);
            }
        }

        [DefaultValue(false)]
        public bool Required { get; set; }
    }
}
