using BussinessObject.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthyCare.Views
{
    public interface IBookingHistory
    {
        void GetHistory(DataSet dsHistory);
        void FinishBooking(bool check);
        void GetBookingInformation(Booking booking);
    }
}
