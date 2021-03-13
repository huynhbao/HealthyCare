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

namespace HealthyCare.UI.Customer
{
    using BussinessObject.Entities;
    using HealthyCare.Presenters;
    using HealthyCare.Views;

    public partial class frmDoctorDetail : DarkForm, IUser
    {
        private Doctor doctor = null;
        private UserPresenter userPresenter = null;
        public frmDoctorDetail(Doctor doctor)
        {
            InitializeComponent();
            this.doctor = doctor;
            userPresenter = new UserPresenter(this);
            LoadData();
        }

        public string UserID { get; set; }
        public string Password { get; set; }
        public string FullName { get; set; }
        public bool Gender { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }

        private void LoadData()
        {
            lbFullName.Text = doctor.FullName;
            lbAddress.Text = doctor.Address;
            lbEmail.Text = doctor.Email;
            lbPhone.Text = doctor.Phone;

            if (doctor.Gender)
            {
                lbGender.Text = "Male";
            } else
            {
                lbGender.Text = "Female";
            }

            lbNumOfBooking.Text = userPresenter.GetNumOfBooking(doctor.UserID).ToString();
            lbCertificate.Text = doctor.Certificate.Name;
        }
    }
}
