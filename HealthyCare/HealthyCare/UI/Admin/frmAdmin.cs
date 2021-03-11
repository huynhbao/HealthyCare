using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HealthyCare.UI.Admin
{
    using BussinessObject.Entities;

    public partial class frmAdmin : Form
    {
        User user = null;
        public frmAdmin(User user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void btnCreateDoctor_Click(object sender, EventArgs e)
        {
            new frmCreateDoctor().ShowDialog();
        }
    }
}
