using DarkUI.Forms;
using HealthyCare.Presenters;
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

namespace HealthyCare.UI.Customer
{
    using BussinessObject.Entities;
    using HealthyCare.Utils;
    using Microsoft.AspNet.SignalR.Client;

    public partial class frmBooking : DarkForm, IBooking
    {
        private Booking booking = null;
        private UserPresenter userPresenter = null;
        LoadingFormUtils loadingForm = new LoadingFormUtils();

        public frmBooking()
        {
            InitializeComponent();
            userPresenter = new UserPresenter(this);
            userPresenter.OnDataLoading += DoctorPresenter_OnDataLoading;
            userPresenter.OnDataLoadingCompleted += DoctorPresenter_OnDataLoadingCompleted;
        }

        public void BookingInformation(Booking booking)
        {
            this.booking = booking;
            SignalR_Services.HubProxy.Invoke("AddGroup", booking);
            LoadData();
            ConnectAsync();
        }

        public void SetStatus(int status)
        {
            booking.Status = status;
            if (status == 2)
            {
                txtChat.AppendText("Doctor confirmed your booking." + Environment.NewLine);
                btnSend.Enabled = true;
            }
        }

        private void DoctorPresenter_OnDataLoadingCompleted()
        {
            loadingForm.Close();
        }

        private void DoctorPresenter_OnDataLoading()
        {
            loadingForm.Show();
        }

        void LoadData()
        {
            if (LoginInfo.user.Role.RoleID.Equals("3"))
            {
                lbFullNameCus.Text = booking.Doctor.FullName;
                lbAddress.Text = booking.Doctor.Address;
                lbEmail.Text = booking.Doctor.Email;
                lbPhone.Text = booking.Doctor.Phone;
                lbTime.Text = booking.Time.ToString();

                if (booking.Doctor.Gender)
                {
                    lbGender.Text = "Male";
                }
                else
                {
                    lbGender.Text = "Female";
                }

                if (booking.Status == 1)
                {
                    txtChat.Text = "Waiting for doctor confirm..." + Environment.NewLine;
                    btnSend.Enabled = false;

                }
            }


        }

        private void ConnectAsync()
        {
            SignalR_Services.HubProxy.On<Booking, string, string>("Chat", (booking, msg, action) =>
            {
                if (action.Equals("ChatDoctorSend"))
                {
                    Invoke((Action)(() =>
                    {
                        txtChat.AppendText(string.Format("{0}: {1} \r\n", booking.Doctor.FullName, msg));
                    }));
                }
            });
        }

        private void btnCancelBooking_Click(object sender, EventArgs e)
        {
            userPresenter.CancelBooking(booking.BookingID);
        }

        public void CancelBooking(bool check)
        {
            if (check)
            {
                MessageBox.Show("Canceled Sucessful", "Message");
                Hide();
            }
            else
            {
                MessageBox.Show("Cannot Cancel", "Message");
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            string msg = txtContent.Text.Trim();
            SignalR_Services.HubProxy.Invoke("ChatUserSend", booking, msg);
            Invoke((Action)(() =>
            {
                txtChat.AppendText(string.Format("You: {0} \r\n", msg));
            }));
            txtContent.Text = String.Empty;
            txtContent.Focus();
        }

        private void darkTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtChat_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
