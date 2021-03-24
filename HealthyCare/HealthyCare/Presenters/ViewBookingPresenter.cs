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

    public class ViewBookingPresenter
    {
        private IViewBooking bookingView;
        private IBookingHistory historyView;
        private IViewFeedback feedbackView;
        private DoctorData doctorData = new DoctorData();
        User user = null;
        public event WaitCallBack OnDataLoading;
        public event WaitCompletedCallBack OnDataLoadingCompleted;

        public ViewBookingPresenter(IViewBooking view)
        {
            user = LoginInfo.user;
            bookingView = view;

        }
        public ViewBookingPresenter(IBookingHistory view)
        {
            user = LoginInfo.user;
            historyView = view;
        }
        public ViewBookingPresenter(IViewFeedback view)
        {
            user = LoginInfo.user;
            feedbackView = view;
        }

        public void GetBooking(string idDoctor)
        {
            if (OnDataLoading != null)
            {
                OnDataLoading();
            }
            DataSet data = doctorData.GetBooking(idDoctor);
            if (OnDataLoadingCompleted != null)
            {
                OnDataLoadingCompleted();
            }
            bookingView.GetBooking(data);
        }

        public void AcceptBooking(string idBooking, string UserID)
        {
            if (OnDataLoading != null)
            {
                OnDataLoading();
            }
            bool check = doctorData.CheckWaitingBooking(user.UserID);
            if (check)
            {
                doctorData.AcceptBooking(idBooking);
            }
            if (OnDataLoadingCompleted != null)
            {
                OnDataLoadingCompleted();
            }
            bookingView.AcceptBooking(check, UserID);
        }
        public void RejectBooking(string idBooking)
        {
            if (OnDataLoading != null)
            {
                OnDataLoading();
            }
            bool result = doctorData.RejectBooking(idBooking);
            if (OnDataLoadingCompleted != null)
            {
                OnDataLoadingCompleted();
            }
            bookingView.RejectBooking(result);
        }public void FinishBooking(string idBooking)
        {
            if (OnDataLoading != null)
            {
                OnDataLoading();
            }
            bool result = doctorData.FinishBooking(idBooking);
            if (OnDataLoadingCompleted != null)
            {
                OnDataLoadingCompleted();
            }
            historyView.FinishBooking(result);
        }

        public void GetUserInformationByID(string UserID)
        {
            if (OnDataLoading != null)
            {
                OnDataLoading();
            }
            User userCus = doctorData.GetUserInformationByID(UserID);
            if (OnDataLoadingCompleted != null)
            {
                OnDataLoadingCompleted();
            }
            bookingView.GetUserInformationByID(user);
        }
        public void GetHistory()
        {
            if (OnDataLoading != null)
            {
                OnDataLoading();
            }
            DataSet data = doctorData.GetHistory(user.UserID);
            if (OnDataLoadingCompleted != null)
            {
                OnDataLoadingCompleted();
            }
            historyView.GetHistory(data);
        }
        public void GetFeedback()
        {
            if (OnDataLoading != null)
            {
                OnDataLoading();
            }
            DataSet data = doctorData.GetFeedback(user.UserID);
            if (OnDataLoadingCompleted != null)
            {
                OnDataLoadingCompleted();
            }
            feedbackView.GetFeedback(data);
        }
    }
}
