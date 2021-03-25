﻿using DarkUI.Forms;
using HealthyCare.Presenters;
using HealthyCare.Utils;
using HealthyCare.Views;
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
    
    public partial class frmViewFeedbacks : DarkForm, IViewFeedback
    {
        ViewBookingPresenter viewBookingPresenter = null;
        DataSet dsFeedback;
        public frmViewFeedbacks()
        {
            InitializeComponent();
            viewBookingPresenter = new ViewBookingPresenter(this);
            LoadData();
        }

        public void GetFeedback(DataSet dsFeedback)
        {
            this.dsFeedback = dsFeedback;
            dgvFeedback.DataSource = dsFeedback.Tables[0];
        }
        private void LoadData()
        {
            viewBookingPresenter.GetFeedback();
        }

    }
}
