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
        IFeedback feedbackView;
        IPassword passwordView;
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
        public UserPresenter(IPassword view)
        {
            user = LoginInfo.user;
            passwordView = view;
        }

        public UserPresenter(ICustomer view)
        {
            user = LoginInfo.user;
            customerView = view;
        }
        public UserPresenter(IFeedback view)
        {
            user = LoginInfo.user;
            feedbackView = view;
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
        {
            ;
            if (OnDataLoading != null)
            {
                OnDataLoading();
            }
            Doctor doctor = doctorData.GetDoctorByID(doctorID);
            if (OnDataLoadingCompleted != null)
            {
                OnDataLoadingCompleted();
            }
            customerView.GetDoctorByID(doctor);
        }
        public void GetDoctorByIDHistory(string doctorID)
        {
            if (OnDataLoading != null)
            {
                OnDataLoading();
            }
            Doctor doctor = doctorData.GetDoctorByID(doctorID);
            if (OnDataLoadingCompleted != null)
            {
                OnDataLoadingCompleted();
            }
            historyView.GetDoctorByID(doctor);
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
            Doctor doctor = null;
            if (check)
            {
                userData.BookDoctor(DoctorID, user.UserID, DateTime.Now);
                doctor = doctorData.GetDoctorByID(DoctorID);
            }

            customerView.BookDoctor(check, doctor);
        }
        public void Feedback(int bookingID, string comment, int value)
        {
            Boolean check = userData.CheckPreviousFeedback(user.UserID, bookingID);
            if (!check)
            {
                userData.Feedback(user.UserID, bookingID, comment, value);
            }
            feedbackView.Feedback(check);
        }
        public void ChangePassword(string curPw, string newPw)
        {
            Boolean check = userData.CheckPassword(user.UserID, curPw);
            if (check)
            {
                userData.ChangePassword(user.UserID, newPw);
            }
            passwordView.ChangePassword(check);
        }

        public void CancelBooking(int bookingID)
        {
            bool check = userData.SetStatusBooking(bookingID, 4);
            historyView.CancelBooking(check);
        }
    }
}
