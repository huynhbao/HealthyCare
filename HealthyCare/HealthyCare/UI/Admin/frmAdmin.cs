using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HealthyCare.UI.Admin
{
    using BussinessObject.Entities;
    using HealthyCare.Presenters;
    using HealthyCare.Views;

    public partial class frmAdmin : Form, IAdmin
    {
        User user = null;
        UserPresenter userPresenter = null;
        private DataSet dsAdmin;
        private DataTable dtAdmin;
        public frmAdmin()
        {
            InitializeComponent();
            user = LoginInfo.user;
            userPresenter = new UserPresenter(this);
            LoadData();
        }
        public void LoadData()
        {
            userPresenter.GetUsers();
        }
        private void btnCreateDoctor_Click(object sender, EventArgs e)
        {
            new frmCreateDoctor().ShowDialog();
        }

        void IAdmin.GetUsers(DataSet data)
        {
            dsAdmin = data;
            dtAdmin = dsAdmin.Tables[0];
            dgvUser.DataSource = dtAdmin;
        }
        private void dgvUser_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvUser.Columns[e.ColumnIndex].Name.Equals("status"))
            {
                bool userStatus = bool.Parse(e.Value.ToString());
                switch (userStatus)
                {
                    case true:
                        e.Value = "Active";
                        break;
                    case false:
                        e.Value = "Inactive";
                        break;
                }
            }
        }
        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            if (dgvUser.SelectedRows.Count > 0)
            {
                String userId = dgvUser.SelectedRows[0].Cells[0].Value.ToString();
                dtAdmin = dsAdmin.Tables[0];
                DataRow dr = dtAdmin.Rows[dgvUser.SelectedRows[0].Index];
                int status = int.Parse(dr["status"].ToString());

                switch (status)
                {
                    case 1:
                        userPresenter.DeleteUser(userId);
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

        void IAdmin.DeleteUser(bool check)
        {
            if (check)
            {
                MessageBox.Show("Delete Sucessful", "Message");
                LoadData();
            }
            else
            {
                MessageBox.Show("Cannot Delete", "Message");
            }
        }
    }
}
