﻿
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HealthyCare.UI.Doctor
{
    using BussinessObject.Entities;
    using DarkUI.Forms;
    using HealthyCare.Presenters;

    public partial class frmDoctor : DarkForm
    {
        User user = null;
        DoctorPresenter doctorPresenter = null; 
        public frmDoctor()
        {
            InitializeComponent();
            user = LoginInfo.user;
        }


    }
}
