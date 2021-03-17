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
        LoadingFormUtils loadingForm = new LoadingFormUtils();
        Form form = null;


        public UserPresenter(IUser view)
        {
            user = LoginInfo.user;
            userView = view;
        }

        public UserPresenter(IHistory view)
        {
            user = LoginInfo.user;
            historyView = view;
            form = view.Form;
        }

        public UserPresenter(ICustomer view)
        {
            user = LoginInfo.user;
            customerView = view;
            form = view.Form;
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
            loadingForm.Show(form);
            DataSet data = doctorData.GetDoctors();
            loadingForm.Close();
            customerView.GetDoctors(data);
        }

        public void GetDoctorByID(string doctorID)
        {
            loadingForm.Show(form);
            Doctor doctor = doctorData.GetDoctorByID(doctorID);
            loadingForm.Close();
            customerView.GetDoctorByID(doctor);
        }

        public void GetHistory()
        {
            loadingForm.Show(form);
            DataSet data = userData.GetHistory(user.UserID);
            loadingForm.Close();
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
