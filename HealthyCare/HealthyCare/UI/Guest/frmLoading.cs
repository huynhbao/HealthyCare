using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HealthyCare.UI.Guest
{
    public partial class frmLoading : Form
    {
        public frmLoading()
        {
            InitializeComponent();
        }

        public frmLoading(Form parent)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterParent;
            if (parent != null)
            {
                StartPosition = FormStartPosition.Manual;
                Location = new Point(parent.Location.X + parent.Width / 2 - this.Width / 2,
                    parent.Location.Y + parent.Height / 2 - Height / 2);
            }
            else
                StartPosition = FormStartPosition.CenterParent;
        }

        public void CloseWaitForm()
        {
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
