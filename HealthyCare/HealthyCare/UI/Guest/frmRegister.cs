using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using HealthyCare.Views;
using HealthyCare.Presenters;
using DarkUI.Forms;

namespace HealthyCare
{
    public partial class frmRegister : DarkForm, IUser
    {
        public frmRegister()
        {
            InitializeComponent();
        }

        public string UserID { get => txtUserID.Text; set => txtUserID.Text = value; }
        public string Password { get => txtPassword.Text; set => txtPassword.Text = value; }
        public string FullName { get => txtFullname.Text; set => txtFullname.Text = value; }
        public string Gender { get => txtGender.Text; set => txtGender.Text = value; }
        public string Email { get => txtEmail.Text; set => txtEmail.Text = value; }
        public string Address { get => txtAddress.Text; set => txtAddress.Text = value; }
        public string Phone { get => txtPhone.Text; set => txtPhone.Text = value; }


        private UserPresenter presenter;
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtUserID.Text == "" || txtPassword.Text == "")
                MessageBox.Show("Please fill sandatory fields");
            else if (txtPassword.Text != txtConfirm.Text)
                MessageBox.Show("Password do not match");
            else
            {
                presenter = new UserPresenter(this);
                bool check = presenter.CheckRegister();
                string s = (check == true ? "successful" : "fail");
                MessageBox.Show("Register " + s);
                Clear();
                this.Hide();
            }
        }
        void Clear()
        {
            txtFullname.Text = txtGender.Text = txtAddress.Text = txtEmail.Text = txtUserID.Text = txtPassword.Text = txtConfirm.Text = txtPhone.Text = "";
        }

        
    }
}
