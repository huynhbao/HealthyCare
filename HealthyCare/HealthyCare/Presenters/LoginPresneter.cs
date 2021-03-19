using BussinessObject;
using BussinessObject.Entities;
using HealthyCare.Utils;
using HealthyCare.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HealthyCare.Presenters
{
    public delegate void WaitCallBack();
    public delegate void WaitCompletedCallBack();

    class LoginPresneter
    {
        ILogin userView;
        UserData userData = new UserData();
        string UserID, Password = "";

        public LoginPresneter(ILogin view)
        {
            userView = view;
            UserID = view.UserID;
            Password = view.Password;
        }

        public event WaitCallBack OnDataLoading;
        public event WaitCompletedCallBack OnDataLoadingCompleted;

        public void CheckLogin()
        {
            if (OnDataLoading != null)
            {
                OnDataLoading();
            }
            //loadingForm.Show(form);
            User userObj = userData.Login(UserID, Password);
            //loadingForm.Close();
            if (OnDataLoadingCompleted != null)
            {
                OnDataLoadingCompleted();
            }
            userView.Login(userObj);
        }
    }
}
