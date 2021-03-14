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
    public partial class frmHistory : DarkForm, IUser
    {
        UserPresenter userPresenter = null;
        DataSet dsHistory;


        public frmHistory()
        {
            InitializeComponent();
            userPresenter = new UserPresenter(this);
            LoadData();
        }

        void LoadData()
        {
            dsHistory = userPresenter.GetBooking();

            dgvHistory.DataSource = dsHistory.Tables[0];
            dgvHistory.Columns[1].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm";
        }

        string IUser.UserID { get; set; }
        string IUser.Password { get; set; }
        string IUser.FullName { get; set; }
        bool IUser.Gender { get; set; }
        string IUser.Email { get; set; }
        string IUser.Address { get; set; }
        string IUser.Phone { get; set; }
    }
}
