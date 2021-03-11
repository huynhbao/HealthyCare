﻿using BussinessObject.Entities;
using DarkUI.Forms;
using HealthyCare.Presenters;
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

namespace HealthyCare.UI.Admin
{
    public partial class frmCreateDoctor : DarkForm, IDoctor
    {
        public frmCreateDoctor()
        {
            InitializeComponent();
        }

        public Certificate Certificate { get => new Certificate(0, txtCertificate.Text); set => new Certificate(0, txtCertificate.Text); }
        public string UserID { get => txtUserID.Text; set => txtUserID.Text = value; }
        public string Password { get => txtPassword.Text; set => txtPassword.Text = value; }
        public string FullName { get => txtFullname.Text; set => txtFullname.Text = value; }
        public bool Gender { get => getGender(); set => getGender(); }
        public string Email { get => txtEmail.Text; set => txtEmail.Text = value; }
        public string Address { get => txtAddress.Text; set => txtAddress.Text = value; }
        public string Phone { get => txtPhone.Text; set => txtPhone.Text = value; }
        

        bool getGender()
        {
            if (rbMale.Checked)
            {
                return true;
            }
            return false;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtUserID.Text == "" || txtPassword.Text == "")
                MessageBox.Show("Please fill sandatory fields");
            else if (txtPassword.Text != txtConfirm.Text)
                MessageBox.Show("Password do not match");
            else
            {
                DoctorPresenter presenter = new DoctorPresenter(this);
                bool check = presenter.CheckRegister();
                string s = (check == true ? "successful" : "fail");
                MessageBox.Show("Register " + s);
                this.Hide();
            }
        }
    }
}