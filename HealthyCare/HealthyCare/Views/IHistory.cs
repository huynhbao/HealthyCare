using BussinessObject.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthyCare.Views
{
    public interface IHistory
    {
        void GetHistory(DataSet dsHistory);
        void GetDoctorByID(Doctor doctor);
        void CancelBooking(bool check);
    }
}
