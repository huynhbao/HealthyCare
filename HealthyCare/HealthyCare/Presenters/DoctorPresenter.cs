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
        private IDoctor doctorView;
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
