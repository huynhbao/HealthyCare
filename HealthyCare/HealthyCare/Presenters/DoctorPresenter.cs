using BussinessObject.DataAccess;
using BussinessObject.Entities;
using HealthyCare.Views;
using System;
using System.Collections.Generic;
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

        public bool CheckRegister()
        {
            return doctorData.Register(doctor);
        }
    }
}
