using BussinessObject.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthyCare.Views
{
    public interface IDoctor : IUser
    {
        Certificate Certificate { get; set; }

        void Register(bool isCreated);
        void GetTotalBooking(int total);
        

    }
}
