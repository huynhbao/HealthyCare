using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HealthyCare.UI.Guest
{
    public partial class frmLoading : Form
    {

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );

        public frmLoading()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterParent;
        }

        public frmLoading(Form parent)
        {
            InitializeComponent();
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 10, 10));
            if (parent != null)
            {
                /*Console.WriteLine(parent.Text);
                Console.WriteLine(parent.Location.X);
                Console.WriteLine(parent.Location.Y);*/
                StartPosition = FormStartPosition.Manual;
                //Location = new Point(173 + parent.Width / 2 - Width / 2, 0 + parent.Height / 2 - Height / 2);
                Location = new Point(parent.Location.X + parent.Width / 2 - Width / 2,
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
