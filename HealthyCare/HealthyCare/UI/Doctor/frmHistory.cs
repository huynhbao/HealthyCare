using BussinessObject.Entities;
using DarkUI.Forms;
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
    public partial class frmHistory : DarkForm, IBookingHistory
    {
        ViewBookingPresenter viewBookingPresenter = null;
        DataSet dsHistory;
        LoadingFormUtils loadingForm = new LoadingFormUtils();
        public frmHistory()
        {
            InitializeComponent();
            viewBookingPresenter = new ViewBookingPresenter(this);
            viewBookingPresenter.OnDataLoading += ViewBookingPresenter_OnDataLoading;
            viewBookingPresenter.OnDataLoadingCompleted += ViewBookingPresenter_OnDataLoadingCompleted; ;
        }

        private void ViewBookingPresenter_OnDataLoadingCompleted()
        {
            loadingForm.Close();
        }

        private void ViewBookingPresenter_OnDataLoading()
        {
            loadingForm.Show();
        }

        void IBookingHistory.GetHistory(DataSet dsHistory)
        {
            this.dsHistory = dsHistory;
            dgvHistory.DataSource = dsHistory.Tables[0];
        }
        private void LoadData()
        {
            viewBookingPresenter.GetHistory();
        }

        private void dgvHistory_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvHistory.Columns[e.ColumnIndex].Name.Equals("status"))
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

        private void frmHistory_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            if (dgvHistory.SelectedRows.Count > 0)
            {
                string BookingID = dgvHistory.SelectedRows[0].Cells[0].Value.ToString();
                DialogResult dialogResult = MessageBox.Show("Do you want to finish this booking?", "Confirm", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    DataTable dtHistory = dsHistory.Tables[0];
                    DataRow dr = dtHistory.Rows[dgvHistory.SelectedRows[0].Index];
                    int status = int.Parse(dr["status"].ToString());
                    switch (status)
                    {
                        case 1:
                            MessageBox.Show("This booking has not been comfirmed.", "Message");
                            break;
                        case 2:
                            viewBookingPresenter.FinishBooking(BookingID);
                            LoadData();
                            break;
                        case 3:
                            MessageBox.Show("This booking has been done.", "Message");
                            break;
                        case 4:
                            MessageBox.Show("This booking has been canceled", "Message");
                            break;

                    }
                    
                }
            }

        }

        public void FinishBooking(bool check)
        {
            if (check)
            {
                MessageBox.Show("Finish successfull.");
            }
            else
            {
                MessageBox.Show("Cannot Finish.");
            }
        }

        private void btnChat_Click(object sender, EventArgs e)
        {
            if (dgvHistory.SelectedRows.Count > 0)
            {
                string BookingID = dgvHistory.SelectedRows[0].Cells[0].Value.ToString();
                viewBookingPresenter.GetBookingInformation(BookingID);
            }
        }

        void IBookingHistory.GetBookingInformation(Booking booking)
        {
            if (booking != null)
            {
                frmChat frm = new frmChat(booking);
                if ((Application.OpenForms["frmChat"] as frmChat) == null)
                {
                    
                    frm.Show();
                } else
                {
                    frm.BringToFront();
                }
                
            }
        }
    }
}
