﻿using BussinessObject.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthyCare.Views
{
    public interface ICustomer : ILoading
    {
        void GetDoctors(DataSet data);
        void GetDoctorByID(Doctor doctor);
        void GetNumOfBooking(DataSet data);
        void BookDoctor(bool check);
    }
}
