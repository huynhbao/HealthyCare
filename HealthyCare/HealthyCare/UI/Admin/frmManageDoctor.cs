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

namespace HealthyCare.UI.Admin
{
    public partial class frmManageDoctor : DarkForm, IAdmin
    {
        AdminPresenter adminPresenter = null;
        private DataSet dsAdmin;
        private DataTable dtAdmin;
        public frmManageDoctor()
        {
            InitializeComponent();
            adminPresenter = new AdminPresenter(this);
            LoadData();
        }
        public void LoadData()
        {
            adminPresenter.GetData();
        }
        public void GetData(DataSet data)
        {
            dsAdmin = data;
            dtAdmin = dsAdmin.Tables[0];

            MyUtils.ConvertColumnType(ref dtAdmin, "status", typeof(int));
            MyUtils.ConvertColumnType(ref dtAdmin, "gender", typeof(int));
            dgvDoctor.DataSource = dtAdmin;
            DataView dv = dtAdmin.DefaultView;
            string filter = "idRole = 2";
            dv.RowFilter = filter;
            dgvDoctor.Columns["idRole"].Visible = false;
            dgvDoctor.CellFormatting += DgvDoctor_CellFormatting;
        }

        private void DgvDoctor_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvDoctor.Columns[e.ColumnIndex].Name.Equals("status"))
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
            if (dgvDoctor.Columns[e.ColumnIndex].Name.Equals("gender"))
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
        public void DeleteUser(bool check)
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

        private void btnCreateDoctor_Click(object sender, EventArgs e)
        {
            new frmCreateDoctor().ShowDialog();
        }

        private void btnDeleteDoctor_Click(object sender, EventArgs e)
        {
            if (dgvDoctor.SelectedRows.Count > 0)
            {
                String userId = dgvDoctor.SelectedRows[0].Cells[0].Value.ToString();
                dtAdmin = dsAdmin.Tables[0];
                DataRow dr = dtAdmin.Rows[dgvDoctor.SelectedRows[0].Index];
                int status = int.Parse(dr["status"].ToString());
                switch (status)
                {
                    case 1:
                        adminPresenter.DeleteUser(userId);
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
    }
}
