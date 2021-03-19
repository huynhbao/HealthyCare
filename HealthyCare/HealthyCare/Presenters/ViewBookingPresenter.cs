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
        public ViewBookingPresenter(IViewBooking view)
        {
            user = LoginInfo.user;
            bookingView = view;

        }
        public void GetBooking(String idDoctor)
        {
            DataSet data = doctorData.GetBooking(idDoctor);
            bookingView.GetBooking(data);
        }
        public void AcceptBooking(String idBooking)
        {
            bool check = doctorData.CheckWaitingBooking(user.UserID);
            if (check)
            {
                doctorData.AcceptBooking(idBooking);
            }
            bookingView.AcceptBooking(check);
        }
        public bool RejectBooking(String idBooking)
        {
            bool result = doctorData.RejectBooking(idBooking);
            return result;
        }
    }
}
