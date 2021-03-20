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
    using HealthyCare.Utils;
    using HealthyCare.Views;

    public partial class frmDoctor : DarkForm, IViewBooking
    {
        User user = null;
        ViewBookingPresenter viewBookingPresenter = null;
        DataSet dsDoctor;
        DataTable dtDoctor;
        Form activeForm = null;
        Button activeButton = null;
        LoadingFormUtils loadingFormUtils = new LoadingFormUtils();

        public frmDoctor()
        {
            InitializeComponent();
            user = LoginInfo.user;
            viewBookingPresenter = new ViewBookingPresenter(this);
            viewBookingPresenter.OnDataLoading += Presenter_OnDataLoading;
            viewBookingPresenter.OnDataLoadingCompleted += Presenter_OnDataLoadingCompleted;
            ActiveButton(btnHome);
            
        }
        private void Presenter_OnDataLoadingCompleted()
        {
            loadingFormUtils.Close();
        }

        private void Presenter_OnDataLoading()
        {
            loadingFormUtils.Show(this);
        }

        public void LoadData()
        {
            viewBookingPresenter.GetBooking(user.UserID);
            lbFullName.Text = "Hi! " + user.FullName;
        }

        private void ActiveButton(Button btn)
        {
            DisableButton();
            activeButton = btn;
            activeButton.BackColor = Color.FromArgb(79, 79, 79);
            lbParentForm.Text = "Home";
        }

        private void DisableButton()
        {
            if (activeButton != null)
            {
                activeButton.BackColor = Color.FromArgb(45, 45, 45);
            }
        }

        private void openChildForm(Form childForm, Button btn)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnView.Controls.Add(childForm);
            pnView.Tag = childForm;
            childForm.Location = Location;
            childForm.BringToFront();
            childForm.Show();
            lbParentForm.Text = childForm.Text;
            ActiveButton(btn);
        }

        void IViewBooking.GetBooking(DataSet data)
        {
            dsDoctor = data;
            dtDoctor = dsDoctor.Tables[0];
            dgvDoctor.DataSource = dtDoctor;
            lbCount.Text = "You have: " + dtDoctor.Compute("COUNT(idBooking)", string.Empty).ToString() + "(s) request from customer";
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void dgvDoctor_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvDoctor.Columns[e.ColumnIndex].Name.Equals("status"))
            {
                int bookingStatus = (int)e.Value;
                switch (bookingStatus)
                {
                    case 1:
                        e.Value = "Waiting";
                        break;
                    case 2:
                        e.Value = "Confirmed";
                        break;
                    case 3:
                        e.Value = "Done";
                        break;
                    case 4:
                        e.Value = "Canceled";
                        break;

                }
            }
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (dgvDoctor.SelectedRows.Count > 0)
            {
                string BookingID = dgvDoctor.SelectedRows[0].Cells[0].Value.ToString();
                DialogResult dialogResult = MessageBox.Show("Do you want to accept this booking?", "Confirm", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    viewBookingPresenter.AcceptBooking(BookingID);
                    LoadData();
                }
            }
        }

        private void btnReject_Click(object sender, EventArgs e)
        {
            if (dgvDoctor.SelectedRows.Count > 0)
            {
                string BookingID = dgvDoctor.SelectedRows[0].Cells[0].Value.ToString();
                DialogResult dialogResult = MessageBox.Show("Do you want to reject this booking?", "Confirm", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    viewBookingPresenter.RejectBooking(BookingID);
                    LoadData();
                }
            }
        }

        public void AcceptBooking(bool check)
        {
            if(check)
            {
                MessageBox.Show("Accept successfull.");
            } else
            {
                MessageBox.Show("Just accept waiting booking");
            }
        }

        public void RejectBooking(bool check)
        {
            if (check)
            {
                MessageBox.Show("Reject successfull.");
            } else
            {
                MessageBox.Show("Cannot reject.");
            }
        }

        public void GetUserInformationByID(User user)
        {
            lbAddress.Text = user.Address;
            lbTotal.Text = user.TotalBooking.ToString();
            lbPhone.Text = user.Phone;
            lbFullNameCus.Text = user.FullName;
            lbEmail.Text = user.Email;
            if (user.Gender)
            {
                lbGender.Text = "Male";
            } else
            {
                lbGender.Text = "Female";
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dgvDoctor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string UserID = dtDoctor.Rows[e.RowIndex]["idUser"].ToString();
                viewBookingPresenter.GetUserInformationByID(UserID);
            }
        }

        private void dgvDoctor_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvDoctor.ClearSelection();
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            frmHistory frm = new frmHistory();
            openChildForm(frm, btnHistory);
        }

        private void frmDoctor_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            ActiveButton(btnHome);
            if (activeForm != null)
            {
                activeForm.Close();
            }
        }

        private void btnFeedback_Click(object sender, EventArgs e)
        {
            frmViewFeedbacks frm = new frmViewFeedbacks();
            openChildForm(frm, btnFeedback);
        }

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            MyUtils.ReleaseCapture();
            MyUtils.SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
