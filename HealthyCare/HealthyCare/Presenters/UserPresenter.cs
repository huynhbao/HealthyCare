using BussinessObject;
using BussinessObject.Entities;
using HealthyCare.Views;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthyCare.Presenters
{
    class UserPresenter
    {
        User user = new User();
        private IUser userView;
        UserData userData = new UserData();

        public UserPresenter(IUser view)
        {
            userView = view;
        }

        public void ConnectModelAndView()
        {
            user.UserID = userView.UserID;
            user.Password = userView.Password;

            user.UserID = userView.UserID;
            user.Password = userView.Password;
            user.FullName = userView.FullName;
            user.Address = userView.Address;
            user.Email = userView.Email;
            user.Phone = userView.Phone;
            user.Gender = userView.Gender;

        }

        public User CheckLogin()
        {
            ConnectModelAndView();
            return userData.Login(user.UserID, user.Password);
        }

        public bool CheckRegister()
        {
            ConnectModelAndView();
            return userData.Register(user);
        }

    }
}
