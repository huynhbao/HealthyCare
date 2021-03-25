using BussinessObject.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthyCare.Views
{
    public interface IViewBooking
    {
        void GetBooking(DataSet data);
        void AcceptBooking(bool check, string UserID);
        void RejectBooking(bool check, string UserID);
        void GetUserInformationByID(User user);
    }
}
