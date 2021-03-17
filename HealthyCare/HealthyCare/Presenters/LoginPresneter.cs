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
    class LoginPresneter
    {
        ILogin userView;
        UserData userData = new UserData();
        LoadingFormUtils loadingForm = new LoadingFormUtils();
        string UserID, Password = "";
        Form form = null;

        public LoginPresneter(ILogin view)
        {
            userView = view;
            UserID = view.UserID;
            Password = view.Password;
            form = view.Form;
        }

        public void CheckLogin()
        {
            loadingForm.Show(form);
            User userObj = userData.Login(UserID, Password);
            loadingForm.Close();
            userView.Login(userObj);
        }
    }
}
