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
    using BussinessObject.Entities;
    using DarkUI.Forms;
    using HealthyCare.Presenters;
    using HealthyCare.UI.G;
    using HealthyCare.Utils;
    using HealthyCare.Views;

    public partial class frmAdmin : DarkForm, IAdmin
    {
        User user = null;
        AdminPresenter adminPresenter = null;
        private DataSet dsAdmin;
        private DataTable dtAdmin;
        private DataTable dtFeedback;

        private Form activeForm = null;
        private Button activeButton = null;
        LoadingFormUtils loadingFormUtils = new LoadingFormUtils();

        public frmAdmin()
        {
            InitializeComponent();
            user = LoginInfo.user;
            adminPresenter = new AdminPresenter(this);
            adminPresenter.OnDataLoading += AdminPresenter_OnDataLoading;
            adminPresenter.OnDataLoadingCompleted += AdminPresenter_OnDataLoadingCompleted;
            ActiveButton(btnHome);
        }

        private void AdminPresenter_OnDataLoadingCompleted()
        {
            loadingFormUtils.Close();
        }

        private void AdminPresenter_OnDataLoading()
        {
            loadingFormUtils.Show(this);
        }

        private void ActiveButton(Button btn)
        {
            DisableButton();
            activeButton = btn;
            activeButton.BackColor = Color.FromArgb(79, 79, 79);
            lbParentForm.Text = "Dashboard";
        }

        private void DisableButton()
        {
            if (activeButton != null)
            {
                activeButton.BackColor = Color.FromArgb(45, 45, 45);
            }
        }

        public void LoadData()
        {
            adminPresenter.GetData();
            lbFullName.Text = "Hi! " + user.FullName;
        }

        private void btnCreateDoctor_Click(object sender, EventArgs e)
        {
            new frmCreateDoctor().ShowDialog();
        }

        void IAdmin.GetData(DataSet data)
        {
            dsAdmin = data;
            dtAdmin = dsAdmin.Tables[0];
            
            lbTotalUsers.Text = dtAdmin.Compute("count(idUser)", "idRole = 3").ToString();
            lbTotalDoctors.Text = dtAdmin.Compute("count(idUser)", "idRole = 2").ToString();

            dtFeedback = dsAdmin.Tables[1];
            lbFeedback.Text = dtFeedback.Compute("count(idFeedback)", "").ToString();
        }


        void IAdmin.DeleteUser(bool check)
        {
        }

        private void btnManageUsers_Click(object sender, EventArgs e)
        {
            frmManageUser frm = new frmManageUser();
            openChildForm(frm, btnManageUsers);
        }

        private void openChildForm(Form childForm, Button btn)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnView.Controls.Add(childForm);
            pnView.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lbParentForm.Text = childForm.Text;
            ActiveButton(btn);
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            ActiveButton(btnHome);
            if (activeForm != null)
            {
                activeForm.Close();
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            LoginInfo.user = null;
            frmLogin frm = new frmLogin();
            frm.Show();
            Close();
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

        private void frmAdmin_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
