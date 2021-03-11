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

    public partial class frmViewProfile : DarkForm
    {
        User user = null;
        public frmViewProfile()
        {
            InitializeComponent();
            user = LoginInfo.user;
            lbProfile.Text = "Hello, " + user.UserID;
            lbFullName.Text = user.FullName;
            _ = GetGender;
            lbEmail.Text = user.Email;
            lbAddress.Text = user.Address;
            lbPhone.Text = user.Phone;
        }


        bool GetGender
        {
            get {
                if (rbMale.Checked)
                {
                    return true;
                }
                return false;
            }
            set
            {
                if (user.Gender)
                {
                    rbMale.Checked = true;
                } else
                {
                    rbFemale.Checked = true;
                }
                
            }
            
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            frmEditProfile frm = new frmEditProfile();
            frm.ShowDialog();
        }
    }

    
}
