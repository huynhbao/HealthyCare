using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessObject.Entities
{
    public class User
    {
        public string UserID { get; set; }
        public string Password { get; set; }
        public string FullName { get; set; }
        public bool Gender { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public Role Role { get; set; }
        public bool Status { get; set; }
        public int TotalBooking { get; set; }
    }

    public static class LoginInfo
    {
        public static User user { get; set; }
    }
}
