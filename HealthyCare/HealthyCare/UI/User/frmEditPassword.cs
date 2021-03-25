using DarkUI.Forms;
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
    using HealthyCare.Views;

    public partial class frmEditPassword : DarkForm, IPassword
    {
        User user = null;
        UserPresenter userPresenter = null;
        public frmEditPassword()
        {
            InitializeComponent();
            user = LoginInfo.user;
            userPresenter = new UserPresenter(this);

        }

        public void ChangePassword(bool check)
        {
            if (check)
            {
                MessageBox.Show("Password changed", "Messasge");
                Close();
            }
            else
            {
                MessageBox.Show("Current password is wrong.", "Messasge");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            String curPw = txtCurrentPassword.Text.ToString();
            String newPw = txtNewPassword.Text.ToString();
            String confirm = txtConfirm.Text.ToString();
            if(newPw.Equals(confirm))
            {
                userPresenter.ChangePassword(curPw, newPw);
            } else
            {
                MessageBox.Show("Password does not match.", "Messasge");
            }
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            MyUtils.ReleaseCapture();
            MyUtils.SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
