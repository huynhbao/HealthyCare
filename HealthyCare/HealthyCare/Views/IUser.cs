using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthyCare.Views
{
    public interface IUser
    {
        string UserID { get; set; }
        string Password { get; set; }
        string FullName { get; set; }
        bool Gender { get; set; }
        string Email { get; set; }
        string Address { get; set; }
        string Phone { get; set; }

    }
}
