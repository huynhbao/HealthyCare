using BussinessObject.Entities;
using DarkUI.Forms;
using HealthyCare.Utils;
using Microsoft.AspNet.SignalR.Client;
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
    public partial class frmChat : DarkForm
    {
        private Booking booking = null;
        public frmChat()
        {
            InitializeComponent();
        }

        public frmChat(Booking booking)
        {
            InitializeComponent();
            this.booking = booking;
        }

        private void ConnectAsync()
        {
            SignalR_Services.HubProxy.On<Booking, string, string>("Chat", (booking, msg, action) =>
            {

                if (action.Equals("ChatUserSend"))
                {
                    Invoke((Action)(() =>
                    {
                        txtChat.AppendText(string.Format("{0}: {1} \r\n", booking.User.FullName, msg));
                    }));
                }

            });
        }

        private void frmChat_Load(object sender, EventArgs e)
        {
            SignalR_Services.HubProxy.Invoke("AddGroup", booking);
            ConnectAsync();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            string msg = txtContent.Text.Trim();
            SignalR_Services.HubProxy.Invoke("ChatDoctorSend", booking, msg);
            Invoke((Action)(() =>
            {
                txtChat.AppendText(string.Format("You: {0} \r\n", msg));
            }));
            txtContent.Text = String.Empty;
            txtContent.Focus();
        }

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            MyUtils.ReleaseCapture();
            MyUtils.SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
