using BussinessObject.Entities;
using DarkUI.Forms;
using HealthyCare.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HealthyCare.UI.User
{
    using BussinessObject.Entities;
    using HealthyCare.Presenters;
    using HealthyCare.Utils;

    public partial class frmViewProfile : DarkForm
    {
        User user = null;
        public frmViewProfile()
        {
            InitializeComponent();
            user = LoginInfo.user;
            LoadData();
        }

        private void LoadData()
        {
            lbFullName.Text = user.FullName;
            lbEmail.Text = user.Email;
            lbAddress.Text = user.Address;
            lbPhone.Text = user.Phone;
            if (user.Gender)
            {
                lbGender.Text = "Male";
            }
            else
            {
                lbGender.Text = "Femle";
            }
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            frmEditProfile frm = new frmEditProfile();
            frm.ShowDialog();
            LoadData();
        }

        private void btnUpdatePassword_Click(object sender, EventArgs e)
        {
            frmEditPassword frm = new frmEditPassword();
            frm.ShowDialog();
            LoadData();
        }
    }

    
}
