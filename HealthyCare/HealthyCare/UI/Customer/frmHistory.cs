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
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HealthyCare.UI.Customer
{
    public partial class frmHistory : DarkForm, IHistory
    {
        UserPresenter userPresenter = null;
        DataSet dsHistory;
        LoadingFormUtils loadingForm = new LoadingFormUtils();

        public void GetHistory(DataSet dsHistory)
        {
            this.dsHistory = dsHistory;
            dgvHistory.DataSource = dsHistory.Tables[0];
            loadingForm.Close();
        }

        public frmHistory()
        {
            InitializeComponent();
            userPresenter = new UserPresenter(this);
        }

        void LoadData()
        {
            loadingForm.Show(this);
            userPresenter.GetHistory();
        }

        private void dgvHistory_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            dgvHistory.Columns["bookingDate"].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm";
            if (dgvHistory.Columns[e.ColumnIndex].Name.Equals("status"))
            {
                int bookingStatus = (int) e.Value;
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

        private void btnCancelBooking_Click(object sender, EventArgs e)
        {
            if (dgvHistory.SelectedRows.Count > 0)
            {
                int bookingID = int.Parse(dgvHistory.SelectedRows[0].Cells[0].Value.ToString());
                DataTable dtHistory = dsHistory.Tables[0];
                DataRow dr = dtHistory.Rows[dgvHistory.SelectedRows[0].Index];
                int status = int.Parse(dr["status"].ToString());

                switch (status)
                {
                    case 1:
                        userPresenter.CancelBooking(bookingID);
                        break;
                    case 2:
                        MessageBox.Show("This booking has been confirmed.", "Message");
                        break;
                    case 3:
                        MessageBox.Show("This booking has been done.", "Message");
                        break;
                    case 4:
                        MessageBox.Show("This booking has been canceled.", "Message");
                        break;

                }

            }
            
        }

        void IHistory.CancelBooking(bool check)
        {
            if (check)
            {
                MessageBox.Show("Canceled Sucessful", "Message");
                LoadData();
            } else {
                MessageBox.Show("Cannot Cancel", "Message");
            }
        }

        private void frmHistory_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
