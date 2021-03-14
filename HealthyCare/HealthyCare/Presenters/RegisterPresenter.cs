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
        private IRegister registerView;
        UserData userData = new UserData();

        public RegisterPresenter(IRegister view)
        {
            user = new User();
            registerView = view;
            user.UserID = registerView.UserID;
            user.Password = registerView.Password;
            user.FullName = registerView.FullName;
            user.Address = registerView.Address;
            user.Email = registerView.Email;
            user.Phone = registerView.Phone;
            user.Gender = registerView.Gender;
        }

        public void CheckRegister()
        {
            int check = userData.Register(user);
            registerView.Register(check);
        }

    }
}
