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
        User user = null;
        private IUser userView;
        UserData userData = new UserData();

        public LoginPresneter(IUser view)
        {
            user = new User();
            userView = view;
            user.UserID = userView.UserID;
            user.Password = userView.Password;
        }

        public User CheckLogin()
        {
            return userData.Login(user.UserID, user.Password);
        }
    }
}
