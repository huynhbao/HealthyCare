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

    public partial class frmEditProfile : DarkForm, IUser
    {
        User user = null;
        public frmEditProfile()
        {
            user = LoginInfo.user;
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            txtFullname.Text = user.FullName;
            _ = GetGender;
            lbEmail.Text = user.Email;
            txtAddress.Text = user.Address;
            txtPhone.Text = user.Phone;
            if (user.Gender)
            {
                rbMale.Checked = true;
            }
            else
            {
                rbFemale.Checked = true;
            }
        }

        public string UserID { get; set; }
        public string Password { get; set; }
        public string FullName { get => txtFullname.Text; set => txtFullname.Text = value; }
        public bool Gender { get => GetGender; set => value = GetGender; }
        public string Email { get => user.Email; set => lbEmail.Text = value; }
        public string Address { get => txtAddress.Text; set => txtAddress.Text = value; }
        public string Phone { get => txtPhone.Text; set => txtPhone.Text = value; }

        bool GetGender
        {
            get
            {
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
                }
                else
                {
                    rbFemale.Checked = true;
                }

            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            UserPresenter userPresenter = new UserPresenter(this);
            bool check = userPresenter.UpadteProfile();
            string s = (check == true ? "successful" : "fail");
            MessageBox.Show("Update " + s);
            Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            MyUtils.ReleaseCapture();
            MyUtils.SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
