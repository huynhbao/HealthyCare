using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessObject.Entities
{
    public class Booking
    {
        public int BookingID { get; set; }
        public int Status { get; set; }
        public DateTime Time { get; set; }
        public User User { get; set; }
        public Doctor Doctor { get; set; }
    }
}
