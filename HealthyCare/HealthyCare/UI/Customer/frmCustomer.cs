using DarkUI.Forms;
using HealthyCare.UI.User;
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
    using HealthyCare.Presenters;
    using HealthyCare.Views;
    using HealthyCare.UI.G;
    using HealthyCare.Utils;
    using FontAwesome.Sharp;
    using Microsoft.AspNet.SignalR.Client;
    using System.Net.Http;

    public partial class frmCustomer : DarkForm, ICustomer
    {
        User user = null;
        UserPresenter userPresenter = null;
        private DataSet dsDoctor;
        private DataTable dtDoctor;
        private Form activeForm = null;
        private IconButton activeButton = null;
        LoadingFormUtils loadingForm = new LoadingFormUtils();
        frmBooking bookingForm = new frmBooking();
        //SignalR_Services signalR = new SignalR_Services();

        public frmCustomer()
        {
            InitializeComponent();
            user = LoginInfo.user;
            userPresenter = new UserPresenter(this);
            userPresenter.OnDataLoading += UserPresenter_OnDataLoading;
            userPresenter.OnDataLoadingCompleted += UserPresenter_OnDataLoadingCompleted;
            ActiveButton(btnHome);
        }

        private void UserPresenter_OnDataLoadingCompleted()
        {
            loadingForm.Close();
        }

        private void UserPresenter_OnDataLoading()
        {
            loadingForm.Show(this);
        }

        public void LoadData()
        {
            userPresenter.GetDoctors();

            lbFullName.Text = "Hi! " + user.FullName;

        }

        private void btnMyProfile_Click(object sender, EventArgs e)
        {
            frmViewProfile frm = new frmViewProfile();
            openChildForm(frm, btnProfile);
        }

        private void ActiveButton(IconButton btn)
        {
            DisableButton();
            activeButton = btn;
            activeButton.BackColor = Color.FromArgb(79, 79, 79);
            activeButton.IconColor = Color.FromArgb(255, 63, 128);
            lbParentForm.Text = "Home";
        }

        private void DisableButton()
        {
            if (activeButton != null)
            {
                activeButton.BackColor = Color.FromArgb(45, 45, 45);
                activeButton.IconColor = Color.FromArgb(230, 230, 230);
            }
        }

        private void openChildForm(Form childForm, IconButton btn)
        {
            if (activeForm != null)
            {
                if (activeForm.Name.Equals("frmBooking"))
                {
                    activeForm.Hide();
                } else
                {
                    activeForm.Close();
                }
                
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnView.Controls.Add(childForm);
            pnView.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lbParentForm.Text = childForm.Text;
            ActiveButton(btn);
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            ActiveButton(btnHome);
            if (activeForm != null)
            {
                activeForm.Close();
            }
            LoadData();
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            if (dgvDoctorList.SelectedRows.Count > 0)
            {
                string doctorID = dgvDoctorList.SelectedRows[0].Cells[0].Value.ToString();
                DialogResult dialogResult = MessageBox.Show("Do you want to book this doctor?", "Confirm", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    userPresenter.BookDoctor(doctorID);
                }
            }

        }

        private void btnViewDoctor_Click(object sender, EventArgs e)
        {
            if (dgvDoctorList.SelectedRows.Count > 0)
            {
                string doctorID = dgvDoctorList.SelectedRows[0].Cells[0].Value.ToString();
                userPresenter.GetDoctorByID(doctorID);
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            LoginInfo.user = null;
            SignalR_Services.CloseConnection();
            frmLogin frm = new frmLogin();
            frm.Show();
            Dispose();
        }



        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            MyUtils.ReleaseCapture();
            MyUtils.SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void cbMajor_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataView dv = dtDoctor.DefaultView;
            var majorID = cbMajor.SelectedValue;
            string filter = string.Format("majorID LIKE '%{0}%'", majorID);
            dv.RowFilter = filter;
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            frmHistory frm = new frmHistory();
            openChildForm(frm, btnHistory);
        }

        public void GetDoctors(DataSet data)
        {
            dsDoctor = data;
            dtDoctor = dsDoctor.Tables[0];
            MyUtils.ConvertColumnType(ref dtDoctor, "gender", typeof(int));
            dgvDoctorList.DataSource = dtDoctor;
            dgvDoctorList.Columns["idUser"].Visible = false;
            dgvDoctorList.Columns["majorID"].Visible = false;
            dgvDoctorList.Columns["idCertificate"].Visible = false;



            DataTable dtMajor = dsDoctor.Tables[1];
            DataRow dr = dtMajor.NewRow();
            dr["majorID"] = "";
            dr["name"] = "All";
            dtMajor.Rows.InsertAt(dr, 0);

            cbMajor.DisplayMember = "name";
            cbMajor.ValueMember = "majorID";
            cbMajor.DataSource = dtMajor;

            userPresenter.GetLatestBooking();
        }

        public void GetDoctorByID(Doctor doctor)
        {
            frmDoctorDetail frm = new frmDoctorDetail(doctor);
            frm.ShowDialog();
        }

        public void GetNumOfBooking(DataSet data)
        {
            throw new NotImplementedException();
        }

        public void BookDoctor(bool check, Doctor doctor)
        {
            if (check)
            {
                LoadData();
                SignalR_Services.HubProxy.Invoke("PushNotification", user.UserID, doctor.UserID, "booking");
                MessageBox.Show("Booked successful!\nWaiting for doctor confirming...", "Message");
            }
            else
            {
                MessageBox.Show("You already have another booking!", "Message");
            }
        }

        private void frmCustomer_Load(object sender, EventArgs e)
        {
            ConnectAsync();
            LoadData();
        }

        private void dgvDoctorList_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvDoctorList.Columns[e.ColumnIndex].Name.Equals("gender"))
            {
                if (e.Value != null)
                {
                    int status = int.Parse(e.Value.ToString());
                    switch (status)
                    {
                        case 1:
                            e.Value = "Male";
                            break;
                        case 0:
                            e.Value = "Female";
                            break;
                    }
                }
            }
        }

        private void dgvDoctorList_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvDoctorList.ClearSelection();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void ConnectAsync()
        {
            SignalR_Services.getInstance(LoginInfo.user);
            SignalR_Services.HubProxy.On<User, Doctor, string>("AddMessage", (User, Doctor, msg) =>
            {
                if (msg.Equals("confirm"))
                {
                    Invoke((Action)(() => {
                        DisplayNotificationBalloon("Book Notification", Doctor.FullName + " had confirmed your booking");
                        bookingForm.SetStatus(2);
                    }));
                }

                if (msg.Equals("reject"))
                {
                    Invoke((Action)(() => {
                        DisplayNotificationBalloon("Book Notification", Doctor.FullName + " had rejected your booking");
                        LoadData();
                    }));
                }
            });
        }

        private void DisplayNotificationBalloon(string header, string message)
        {
            NotifyIcon notifyIcon = new NotifyIcon
            {
                Visible = true,
                Icon = Properties.Resources.app_logo1
            };
            if (header != null)
            {
                notifyIcon.BalloonTipTitle = header;
            }
            if (message != null)
            {
                notifyIcon.BalloonTipText = message;
            }
            notifyIcon.BalloonTipClosed += (sender, args) => dispose(notifyIcon);
            notifyIcon.BalloonTipClicked += (sender, args) => dispose(notifyIcon);
            notifyIcon.ShowBalloonTip(0);
        }

        private void dispose(NotifyIcon notifyIcon)
        {
            notifyIcon.Dispose();
        }

        private void frmCustomer_FormClosing(object sender, FormClosingEventArgs e)
        {
            SignalR_Services.CloseConnection();
        }

        void ICustomer.GetLatestBooking(Booking booking)
        {
            if (booking != null)
            {
                bookingForm.BookingInformation(booking);
                openChildForm(bookingForm, btnHome);
            }
        }
    }

}