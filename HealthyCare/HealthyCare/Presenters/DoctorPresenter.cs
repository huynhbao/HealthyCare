using BussinessObject.DataAccess;
using BussinessObject.Entities;
using HealthyCare.Views;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthyCare.Presenters
{
    class DoctorPresenter
    {
        User user = null;
        private IDoctor doctorView;
        private IProfileDoctor profileView;
        private Doctor doctor;
        private DoctorData doctorData = new DoctorData();

        public DoctorPresenter(IDoctor view)
        {
            doctorView = view;
            doctor = new Doctor
            {
                UserID = doctorView.UserID,
                Password = doctorView.Password,
                FullName = doctorView.FullName,
                Address = doctorView.Address,
                Email = doctorView.Email,
                Phone = doctorView.Phone,
                Gender = doctorView.Gender,
                Certificate = doctorView.Certificate
            };
        }
        public DoctorPresenter(IProfileDoctor view)
        {
            user = LoginInfo.user;
            profileView = view;
        }

        public void GetCertificate(String doctorID)
        {
            String certificate = doctorData.GetCertificateById(doctorID);
            profileView.GetCertificate(certificate);
        }
        public void GetMajor(String doctorID)
        {
            String major = doctorData.GetMajorById(doctorID);
            profileView.GetMajor(major);
        }

        public void Register()
        {
            bool check = doctorData.Register(doctor);
            doctorView.Register(check);
        }
        public void GetDoctorTotalBooking(string doctorID)
        {
            int total = doctorData.GetNumOfBooking(doctorID);
            doctorView.GetTotalBooking(total);
        }
    }
}
