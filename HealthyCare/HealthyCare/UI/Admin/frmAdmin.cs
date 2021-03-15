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
    using HealthyCare.Utils;
    using HealthyCare.Views;

    public partial class frmAdmin : Form, IAdmin
    {
        User user = null;
        AdminPresenter userPresenter = null;
        private DataSet dsAdmin;
        private DataTable dtAdmin;
        public frmAdmin()
        {
            InitializeComponent();
            user = LoginInfo.user;
            userPresenter = new AdminPresenter(this);
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
            MyUtils.ConvertColumnType(ref dtAdmin, "status", typeof(int));
            MyUtils.ConvertColumnType(ref dtAdmin, "gender", typeof(int));
            dgvUser.DataSource = dtAdmin;
            dgvUser.CellFormatting += DgvUser_CellFormatting;
        }

        private void DgvUser_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvUser.Columns[e.ColumnIndex].Name.Equals("status"))
            {
                if (e.Value != null)
                {
                    int status = int.Parse(e.Value.ToString());
                    switch (status)
                    {
                        case 1:
                            e.Value = "Active";
                            break;
                        case 0:
                            e.Value = "Inactive";
                            break;
                    }
                }
            }

            if (dgvUser.Columns[e.ColumnIndex].Name.Equals("gender"))
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

        private void dgvUser_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
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

        private void dgvUser_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            
        }
    }
}
