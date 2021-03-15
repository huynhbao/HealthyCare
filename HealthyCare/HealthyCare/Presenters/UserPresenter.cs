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
        IUser userView;
        IAdmin adminView;
        IHistory historyView;
        ICustomer customerView;
        UserData userData = new UserData();
        AdminData adminData = new AdminData();
        DoctorData doctorData = new DoctorData();

        public UserPresenter(IUser view)
        {
            user = LoginInfo.user;
            userView = view;
        }

        public UserPresenter(IHistory view)
        {
            user = LoginInfo.user;
            historyView = view;
        }

        public UserPresenter(ICustomer view)
        {
            user = LoginInfo.user;
            customerView = view;
        }
        public UserPresenter(IAdmin view)
        {
            user = LoginInfo.user;
            adminView = view;
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

        public void GetDoctors()
        {
            DataSet data = doctorData.GetDoctors();
            customerView.GetDoctors(data);
        }
        public void GetUsers()
        {
            DataSet data = adminData.GetUsers();
            adminView.GetUsers(data);
        }
        public void DeleteUser(String userID)
        {
            bool check = adminData.DeleteUser(userID, 0);
            adminView.DeleteUser(check);
        }
        public void GetHistory()
        {
            historyView.GetHistory(userData.GetHistory(user.UserID));
        }

        public void GetDoctorByID(string doctorID)
        {
            Doctor doctor = doctorData.GetDoctorByID(doctorID);
            customerView.GetDoctorByID(doctor);
        }

        public int GetNumOfBooking(string DoctorID)
        {
            return doctorData.GetNumOfBooking(DoctorID);
        }

        public void BookDoctor(string DoctorID)
        {
            bool check = userData.BookDoctor(DoctorID, user.UserID, DateTime.Now);
            customerView.BookDoctor(check);
        }

        public void CancelBooking(int bookingID)
        {
            bool check = userData.SetStatusBooking(bookingID, 4);
            historyView.CancelBooking(check);
        }
    }
}
