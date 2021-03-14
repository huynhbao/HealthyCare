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
using HealthyCare.Utils;
using System.Text.RegularExpressions;
using HealthyCare.UI.G;

namespace HealthyCare
{
    public partial class frmRegister : DarkForm, IRegister
    {
        public frmRegister()
        {
            InitializeComponent();
        }

        public string UserID { get => txtUserID.Text; set => txtUserID.Text = value; }
        public string Password { get => txtPassword.Text; set => txtPassword.Text = value; }
        public string FullName { get => txtFullname.Text; set => txtFullname.Text = value; }
        public bool Gender { get => getGender(); set => getGender(); }
        public string Email { get => txtEmail.Text; set => txtEmail.Text = value; }
        public string Address { get => txtAddress.Text; set => txtAddress.Text = value; }
        public string Phone { get => txtPhone.Text; set => txtPhone.Text = value; }
        

        private RegisterPresenter presenter;
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Regex rgMail = new Regex(MyUtils.EMAIL_FORMAT);
            Regex rgPhone = new Regex(MyUtils.PHONE_FORMAT );
            if (txtUserID.Text == "" || txtAddress.Text == "" || txtEmail.Text == "" || txtPhone.Text == "" || txtFullname.Text == "" || txtPassword.Text == "" || txtConfirm.Text == "")
                MessageBox.Show("Please fill sandatory fields");
            else if (!rgMail.IsMatch(txtEmail.Text)) 
                MessageBox.Show("Email is not correct.");
            else if (!rgPhone.IsMatch(txtPhone.Text))
                MessageBox.Show("Phone is not correct.");
            else if(txtPhone.Text.Length !=10)
                MessageBox.Show("Phone must have 10 number");
            else if(txtPassword.Text != txtConfirm.Text)
                MessageBox.Show("Password do not match");
            else
            {
                presenter = new RegisterPresenter(this);
                presenter.CheckRegister();
            }
        }
        void Clear()
        {
            txtFullname.Text = txtAddress.Text = txtEmail.Text = txtUserID.Text = txtPassword.Text = txtConfirm.Text = txtPhone.Text = "";
        }

        bool getGender()
        {
            if (rbMale.Checked)
            {
                return true;
            }
            return false;
        }

        void LoginForm()
        {
            frmLogin frm = new frmLogin();
            frm.Show();
            Close();
        }

        void IRegister.Register(int status)
        {
            string s;
            switch (status)
            {
                case 0:
                    s = "Successful";
                    MessageBox.Show("Register " + s);
                    Clear();
                    LoginForm();
                    break;
                case 1:
                    s = "Duplicated";
                    MessageBox.Show("Register " + s);
                    break;
                default:
                    s = "Error";
                    MessageBox.Show("Register " + s);
                    break;
            }
            
            
            
        }
    }
}
