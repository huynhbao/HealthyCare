using DarkUI.Forms;
using HealthyCare.UI.User;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HealthyCare.UI.Customer
{
    using BussinessObject.Entities;
    using HealthyCare.Presenters;
    using HealthyCare.Views;

    public partial class frmCustomer : DarkForm, IUser
    {
        User user = null;
        UserPresenter userPresenter = null;
        private Form activeForm = null;
        private Button activeButton = null;
        private PictureBox activePicturebox = null;

        string IUser.UserID { get; set; }
        string IUser.Password { get; set; }
        string IUser.FullName { get; set; }
        bool IUser.Gender { get; set; }
        string IUser.Email { get; set; }
        string IUser.Address { get; set; }
        string IUser.Phone { get; set; }

        public frmCustomer()
        {
            InitializeComponent();
            user = LoginInfo.user;
            userPresenter = new UserPresenter(this);
            setActiveComponent(btnHome, pbHome);
            LoadData();
        }

        public void LoadData()
        {
            List<Doctor> list = userPresenter.ListDoctor();
            dgvDoctorList.DataSource = list;
            dgvDoctorList.Columns["Password"].Visible = false;
            dgvDoctorList.Columns["Role"].Visible = false;
            dgvDoctorList.Columns["Status"].Visible = false;
        }
        
        private void btnMyProfile_Click(object sender, EventArgs e)
        {
            setActiveComponent(btnMyProfile, pbHome);
            frmViewProfile frm = new frmViewProfile();
            openChildForm(frm);
        }

        private void setActiveComponent(Button btn, PictureBox pb)
        {
            activeButton = btn;
            activePicturebox = pb;
            activeButton.BackColor = Color.FromArgb(79, 79, 79);
            activePicturebox.BackColor = Color.FromArgb(79, 79, 79);
        }

        private void openChildForm(Form childForm)
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

            activeButton.BackColor = Color.FromArgb(79, 79, 79);
            activePicturebox.BackColor = Color.FromArgb(79, 79, 79);
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            setActiveComponent(btnHome, pbHome);
            if (activeForm != null)
            {
                activeForm.Close();
            }
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            
        }
    }
}
