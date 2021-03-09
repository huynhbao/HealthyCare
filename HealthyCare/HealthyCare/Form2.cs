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

namespace HealthyCare
{
    public partial class frmRegister : Form
    {
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\OneDrive\Documents\Login.mdf;Integrated Security=True;Connect Timeout=30;";
        public frmRegister()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text == "" || txtPassword.Text == "")
                MessageBox.Show("Please fill sandatory fields");
            else if (txtPassword.Text != txtConfirm.Text)
                MessageBox.Show("Password do not match");
            else
            {
                using (SqlConnection sqlCon = new SqlConnection(connectionString))
                {
                    sqlCon.Open();
                    SqlCommand sqlCmd = new SqlCommand("UserAdd", sqlCon);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("@FULLNAME", txtFullname.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@GENDER", txtGender.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@ADDRESS", txtAddress.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@EMAIL", txtEmail.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@USERNAME", txtUserName.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@PASSWORD", txtPassword.Text.Trim());
                    sqlCmd.ExecuteNonQuery();
                    MessageBox.Show("Registration Successfull!!");
                    Clear();
                }
                this.Hide();
                frmLogin login = new frmLogin();
                login.Show();
            }
        }
        void Clear()
        {
            txtFullname.Text = txtGender.Text = txtAddress.Text = txtEmail.Text = txtUserName.Text = txtPassword.Text = txtConfirm.Text = "";
        }
    }
}
