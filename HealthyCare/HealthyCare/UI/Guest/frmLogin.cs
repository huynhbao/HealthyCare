using BussinessObject.Entities;
using HealthyCare.Presenters;
using HealthyCare.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HealthyCare.Utils;
using DarkUI.Forms;
using HealthyCare.UI.Guest;



namespace HealthyCare.UI.G
{
    using BussinessObject.Entities;
    using HealthyCare.UI.Admin;
    using HealthyCare.UI.Doctor;
    using HealthyCare.UI.Customer;

    public partial class frmLogin : DarkForm, ILogin
    {
        private LoginPresneter presenter;

        public frmLogin()
        {
            InitializeComponent();
        }

        //LoadingFormUtils loadingForm = new LoadingFormUtils();

        public string UserID { get => txtUsername.Text; set => txtUsername.Text = value; }
        public string Password { get => txtPassword.Text; set => txtPassword.Text = value; }
        public Form Form { get => this;}

        private void btnLogin_Click(object sender, EventArgs e)
        {

            //loadingForm.Show(this);
            presenter = new LoginPresneter(this);
            presenter.CheckLogin();
        }


        private void btnRegister_Click(object sender, EventArgs e)
        {
            frmRegister register = new frmRegister();
            register.Show();
            Hide();
        }


        public void Login(User user)
        {
            //loadingForm.Close();
            if (user != null)
            {
                string roleID = user.Role.RoleID;
                LoginInfo.user = user;
                switch (roleID)
                {
                    case "1":
                        frmAdmin frmAdmin = new frmAdmin();
                        frmAdmin.Show();
                        break;
                    case "2":
                        frmDoctor frmDoctor = new frmDoctor();
                        frmDoctor.Show();
                        break;
                    case "3":
                        frmCustomer frmCustomer = new frmCustomer();
                        frmCustomer.Show();
                        break;
                }
                Hide();
            }
            else
            {
                MessageBox.Show("Fail");
            }
        }

    }
}
