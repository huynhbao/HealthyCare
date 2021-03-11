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



namespace HealthyCare.UI.G
{
    using BussinessObject.Entities;
    using HealthyCare.UI.Admin;
    using HealthyCare.UI.Doctor;

    public partial class frmLogin : DarkForm, IUser
    {
        private UserPresenter presenter;
        public frmLogin()
        {
            InitializeComponent();
        }

        

        public string UserID { get => txtUsername.Text; set => txtUsername.Text = value; }
        public string Password { get => txtPassword.Text; set => txtPassword.Text = value; }
        string IUser.FullName { get => null; set => value = null; }
        bool IUser.Gender { get => false; set => value = false; }
        string IUser.Email { get => null; set => value = null; }
        string IUser.Address { get => null; set => value = null; }
        string IUser.Phone { get => null; set => value = null; }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            presenter = new UserPresenter(this);
            User user = presenter.CheckLogin();
            if (user != null)
            {
                string roleID = user.Role.RoleID;
                switch (roleID)
                {
                    case "1":
                        frmAdmin frmAdmin = new frmAdmin(user);
                        frmAdmin.Show();
                        break;
                    case "2":
                        frmDoctor frmDoctor = new frmDoctor(user);
                        frmDoctor.Show();
                        break;
                    case "3":
                        break;
                }
                Hide();
            } else
            {
                MessageBox.Show("Fail");
            }
        }

        

        private void btnRegister_Click(object sender, EventArgs e)
        {
            frmRegister register = new frmRegister();
            register.ShowDialog();
        }

       
    }
}
