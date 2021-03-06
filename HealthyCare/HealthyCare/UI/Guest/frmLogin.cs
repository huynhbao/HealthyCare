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
        LoadingFormUtils loadingFormUtils = new LoadingFormUtils();

        public frmLogin()
        {
            InitializeComponent();
            
        }

        private void Presenter_OnDataLoadingCompleted()
        {
            loadingFormUtils.Close();
        }

        private void Presenter_OnDataLoading()
        {
            loadingFormUtils.Show(this);
        }


        public string UserID { get => txtUsername.Text; set => txtUsername.Text = value; }
        public string Password { get => txtPassword.Text; set => txtPassword.Text = value; }
        public Form Form { get => this;}

        private void btnLogin_Click(object sender, EventArgs e)
        {

            //loadingForm.Show(this);
            presenter = new LoginPresneter(this);
            presenter.OnDataLoading += Presenter_OnDataLoading;
            presenter.OnDataLoadingCompleted += Presenter_OnDataLoadingCompleted;
            presenter.CheckLogin();
            if (chkRemember.Checked)
            {
                Properties.Settings.Default.UserID = txtUsername.Text;
                Properties.Settings.Default.Password = txtPassword.Text;
                Properties.Settings.Default.checkbox = true;
                Properties.Settings.Default.Save();
            } else
            {
                Properties.Settings.Default.Reset();
            }
        }


        private void btnRegister_Click(object sender, EventArgs e)
        {
            frmRegister register = new frmRegister();
            register.Show();
            Hide();
        }


        public void Login(User user)
        {
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

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            MyUtils.ReleaseCapture();
            MyUtils.SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void lbRemember_Click(object sender, EventArgs e)
        {
            chkRemember.Checked = !chkRemember.Checked;
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            chkRemember.Checked = Properties.Settings.Default.checkbox;
            txtUsername.Text = Properties.Settings.Default.UserID;
            txtPassword.Text = Properties.Settings.Default.Password;
        }
    }
}
