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

    public partial class frmDoctorDetail : DarkForm, IDoctor
    {
        private Doctor doctor = null;
        private DoctorPresenter doctorPresenter = null;
        public frmDoctorDetail(Doctor doctor)
        {
            InitializeComponent();
            this.doctor = doctor;
            doctorPresenter = new DoctorPresenter(this);
            LoadData();
        }

        public string UserID { get; set; }
        public string Password { get; set; }
        public string FullName { get; set; }
        public bool Gender { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        Certificate IDoctor.Certificate { get; set; }

        

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

            doctorPresenter.GetDoctorTotalBooking(doctor.UserID);
            lbCertificate.Text = doctor.Certificate.Name;
        }

        void IDoctor.GetTotalBooking(int total)
        {
            lbNumOfBooking.Text = total.ToString();
        }

        void IDoctor.Register(bool isCreated)
        {
            throw new NotImplementedException();
        }
    }
}
