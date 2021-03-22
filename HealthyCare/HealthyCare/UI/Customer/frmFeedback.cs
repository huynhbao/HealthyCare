using BussinessObject.Entities;
using DarkUI.Forms;
using HealthyCare.Presenters;
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
    using BussinessObject.Entities;
    using HealthyCare.Views;

    public partial class frmFeedback : DarkForm, IFeedback
    {
        User user = null;
        UserPresenter userPresenter = null;
        int bookingID;
        public frmFeedback()
        {
            InitializeComponent();
            
        }
        public frmFeedback(int BookingID)
        {
            InitializeComponent();
            this.bookingID = BookingID;
            user = LoginInfo.user;
            userPresenter = new UserPresenter(this);
        }

        public void Feedback(bool check)
        {
            if(!check)
            {
                MessageBox.Show("Feedback successfully.", "Message");
            } else
            {
               MessageBox.Show("You have feedbacked already", "Message");
            }
        }

        private void btnFeedback_Click(object sender, EventArgs e)
        {
            String comment = txtComment.Text.ToString();
            int value = int.Parse(txtRating.Value.ToString());
            userPresenter.Feedback(bookingID, comment, value);
            Close();
        }
    }
}
