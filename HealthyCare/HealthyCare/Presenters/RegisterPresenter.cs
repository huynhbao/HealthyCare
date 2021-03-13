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
    class RegisterPresenter
    {
        User user = null;
        private IUser userView;
        UserData userData = new UserData();

        public RegisterPresenter(IUser view)
        {
            user = new User();
            userView = view;
            user.UserID = userView.UserID;
            user.Password = userView.Password;
            user.FullName = userView.FullName;
            user.Address = userView.Address;
            user.Email = userView.Email;
            user.Phone = userView.Phone;
            user.Gender = userView.Gender;
        }

        public bool CheckRegister()
        {
            return userData.Register(user);
        }

    }
}
