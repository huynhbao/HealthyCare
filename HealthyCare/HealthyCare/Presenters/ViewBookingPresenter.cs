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
        private DoctorData doctorData = new DoctorData();
        User user = null;
        public event WaitCallBack OnDataLoading;
        public event WaitCompletedCallBack OnDataLoadingCompleted;

        public ViewBookingPresenter(IViewBooking view)
        {
            user = LoginInfo.user;
            bookingView = view;

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

        public void AcceptBooking(string idBooking)
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
            bookingView.AcceptBooking(check);
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
    }
}
