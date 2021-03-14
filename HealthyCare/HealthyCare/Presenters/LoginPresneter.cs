using BussinessObject;
using BussinessObject.Entities;
using HealthyCare.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthyCare.Presenters
{
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

        public void CheckLogin()
        {
            User userObj = userData.Login(UserID, Password);
            userView.Login(userObj);
        }
    }
}
