using BussinessObject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthyCare.Views
{

    public interface ILogin : ILoading
    {
        string UserID { get; set; }
        string Password { get; set; }

        void Login(User user);
    }
}
