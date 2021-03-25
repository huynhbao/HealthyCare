using BussinessObject.Entities;
using DarkUI.Forms;
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

namespace HealthyCare.UI.User
{
    using BussinessObject.Entities;
    using HealthyCare.Presenters;
    using HealthyCare.Utils;

    public partial class frmViewProfile : DarkForm, IProfileDoctor
    {
        User user = null;
        String idDoctor = null;
        DoctorPresenter doctorPresenter = null;
        String certificate = null;
        String major = null;
        LoadingFormUtils loadingForm = new LoadingFormUtils();

        public frmViewProfile()
        {
            InitializeComponent();
            user = LoginInfo.user;
            LoadData();
        }
        public frmViewProfile(String doctorID)
        {
            InitializeComponent();
            user = LoginInfo.user;
            this.idDoctor = doctorID;
            doctorPresenter = new DoctorPresenter(this);
            doctorPresenter.OnDataLoading += DoctorPresenter_OnDataLoading;
            doctorPresenter.OnDataLoadingCompleted += DoctorPresenter_OnDataLoadingCompleted;
            LoadData();
        }

        private void DoctorPresenter_OnDataLoadingCompleted()
        {
            loadingForm.Close();
        }

        private void DoctorPresenter_OnDataLoading()
        {
            loadingForm.Show();
        }

        private void LoadData()
        {
            
            lbFullName.Text = user.FullName;
            lbEmail.Text = user.Email;
            lbAddress.Text = user.Address;
            lbPhone.Text = user.Phone;
            if (user.Gender)
            {
                lbGender.Text = "Male";
            }
            else
            {
                lbGender.Text = "Femle";
            }
            if (user.Role.RoleID.Equals("3"))
            {
                lbCertificate.Hide();
                lbMajor.Hide();
                pbCertificate.Hide();
                pbMajor.Hide();
            }
            else
            {
                doctorPresenter.GetCertificate(idDoctor);
                doctorPresenter.GetMajor(idDoctor);
                lbCertificate.Text = certificate;
                lbMajor.Text = major;
            }
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            frmEditProfile frm = new frmEditProfile();
            frm.ShowDialog();
            LoadData();
        }

        private void btnUpdatePassword_Click(object sender, EventArgs e)
        {
            frmEditPassword frm = new frmEditPassword();
            frm.ShowDialog();
            LoadData();
        }

        public void GetCertificate(string certificate)
        {
            this.certificate = certificate;
        }

        public void GetMajor(string major)
        {
            this.major = major; 
        }
    }


}
