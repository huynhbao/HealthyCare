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
        IBooking bookingView;
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

        public UserPresenter(IBooking view)
        {
            user = LoginInfo.user;
            bookingView = view;
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
            if (OnDataLoading != null)
            {
                OnDataLoading();
            }
            bool check = !userData.CheckPreviousBooking(user.UserID);
            Doctor doctor = null;
            if (check)
            {
                userData.BookDoctor(DoctorID, user.UserID, DateTime.Now);
                doctor = doctorData.GetDoctorByID(DoctorID);
            }
            if (OnDataLoadingCompleted != null)
            {
                OnDataLoadingCompleted();
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
            if (OnDataLoading != null)
            {
                OnDataLoading();
            }
            Boolean check = userData.CheckPassword(user.UserID, curPw);
            if (check)
            {
                userData.ChangePassword(user.UserID, newPw);
            }
            if (OnDataLoadingCompleted != null)
            {
                OnDataLoadingCompleted();
            }
            passwordView.ChangePassword(check);
        }

        public void CancelBookingHistory(int bookingID)
        {
            if (OnDataLoading != null)
            {
                OnDataLoading();
            }
            bool check = userData.SetStatusBooking(bookingID, 4);
            if (OnDataLoadingCompleted != null)
            {
                OnDataLoadingCompleted();
            }
            historyView.CancelBooking(check);
        }

        public void CancelBooking(int bookingID)
        {
            if (OnDataLoading != null)
            {
                OnDataLoading();
            }
            bool check = userData.SetStatusBooking(bookingID, 4);
            if (OnDataLoadingCompleted != null)
            {
                OnDataLoadingCompleted();
            }
            bookingView.CancelBooking(check);
        }

        public void GetLatestBooking()
        {
            if (OnDataLoading != null)
            {
                OnDataLoading();
            }
            Booking booking = userData.GetLatestBooking(user);
            if (OnDataLoadingCompleted != null)
            {
                OnDataLoadingCompleted();
            }
            customerView.GetLatestBooking(booking);
        }
    }
}
