using DarkUI.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HealthyCare.UI.Customer
{
    public partial class frmFeedback : DarkForm
    {
        public frmFeedback()
        {
            InitializeComponent();
        }
        public frmFeedback(int BookingID, int idDoctor)
        {
            InitializeComponent();
            int bookingID = BookingID;
            int doctorID = idDoctor;
        }
    }
}
