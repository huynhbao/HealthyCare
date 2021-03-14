using BussinessObject;
using BussinessObject.DataAccess;
using BussinessObject.Entities;
using HealthyCare.Views;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthyCare.Presenters
{
    class UserPresenter
    {
        User user = null;
        private IUser userView;
        UserData userData = new UserData();
        DoctorData doctorData = new DoctorData();

        public UserPresenter(IUser view)
        {
            user = LoginInfo.user;
            userView = view;
        }

        public void ConnectModelAndView()
        {
            user.FullName = userView.FullName;
            user.Address = userView.Address;
            user.Phone = userView.Phone;
            user.Gender = userView.Gender;
        }

        public bool UpadteProfile()
        {
            ConnectModelAndView();
            bool check = userData.UpadteProfile(user);
            return check;
        }

        public DataSet GetDoctors()
        {
            return doctorData.GetDoctors();
        }

        public DataSet GetBooking()
        {
            return userData.GetBooking(user.UserID);
        }

        public Doctor GetDoctorByID(string doctorID)
        {
            return doctorData.GetDoctorByID(doctorID);
        }

        public int GetNumOfBooking(string DoctorID)
        {
            return doctorData.GetNumOfBooking(DoctorID);
        }

        public bool BookDoctor(string DoctorID)
        {
            return userData.BookDoctor(DoctorID, user.UserID, DateTime.Now);
        }
    }
}
