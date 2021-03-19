
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
    using HealthyCare.Views;

    public partial class frmDoctor : DarkForm, IViewBooking
    {
        User user = null;
        DoctorPresenter doctorPresenter = null;
        ViewBookingPresenter viewBookingPresenter = null;
        private DataSet dsDoctor;
        private DataTable dtDoctor;
        public frmDoctor()
        {
            InitializeComponent();
            user = LoginInfo.user;
            viewBookingPresenter = new ViewBookingPresenter(this);
            LoadData();
        }
        public void LoadData()
        {
            viewBookingPresenter.GetBooking(user.UserID);
            lbFullName.Text = "Hi! " + user.FullName;
        }

        void IViewBooking.GetBooking(DataSet data)
        {
            dsDoctor = data;
            dtDoctor = dsDoctor.Tables[0];
            dgvDoctor.DataSource = dtDoctor;
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
            throw new NotImplementedException();
        }
    }
}
