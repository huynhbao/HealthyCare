using BussinessObject;
using BussinessObject.DataAccess;
using BussinessObject.Entities;
using HealthyCare.Utils;
using HealthyCare.Views;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HealthyCare.Presenters
{
    class UserPresenter
    {
        User user = null;
        IUser userView;
        IHistory historyView;
        ICustomer customerView;
        UserData userData = new UserData();
        DoctorData doctorData = new DoctorData();

        public event WaitCallBack OnDataLoading;
        public event WaitCompletedCallBack OnDataLoadingCompleted;

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
            if (OnDataLoading != null)
            {
                OnDataLoading();
            }
            DataSet data = doctorData.GetDoctors();
            if (OnDataLoadingCompleted != null)
            {
                OnDataLoadingCompleted();
            }
            customerView.GetDoctors(data);
        }

        public void GetDoctorByID(string doctorID)
        {;
            Doctor doctor = doctorData.GetDoctorByID(doctorID);
            customerView.GetDoctorByID(doctor);
        }

        public void GetHistory()
        {
            if (OnDataLoading != null)
            {
                OnDataLoading();
            }
            DataSet data = userData.GetHistory(user.UserID);
            if (OnDataLoadingCompleted != null)
            {
                OnDataLoadingCompleted();
            }
            historyView.GetHistory(data);
        }

        public void BookDoctor(string DoctorID)
        {
            bool check = !userData.CheckPreviousBooking(user.UserID);
            if (check)
            {
                userData.BookDoctor(DoctorID, user.UserID, DateTime.Now);
            }
            
            customerView.BookDoctor(check);
        }

        public void CancelBooking(int bookingID)
        {
            bool check = userData.SetStatusBooking(bookingID, 4);
            historyView.CancelBooking(check);
        }
    }
}
