using DarkUI.Forms;
using HealthyCare.UI.User;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HealthyCare.UI.Customer
{
    using BussinessObject.Entities;
    public partial class frmCustomer : DarkForm
    {
        User user = null;
        public frmCustomer()
        {
            InitializeComponent();
            user = LoginInfo.user;
        }

        private void btnMyProfile_Click(object sender, EventArgs e)
        {
            frmViewProfile frm = new frmViewProfile();
            frm.ShowDialog();
        }
    }
}
