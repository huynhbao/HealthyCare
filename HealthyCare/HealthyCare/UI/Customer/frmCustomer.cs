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
    using System.Runtime.InteropServices;
    using HealthyCare.Utils;

    public partial class frmCustomer : DarkForm, ICustomer
    {
        User user = null;
        UserPresenter userPresenter = null;
        private DataSet dsDoctor;
        private DataTable dtDoctor;
        private Form activeForm = null;
        private Button activeButton = null;

        public frmCustomer()
        {
            InitializeComponent();
            user = LoginInfo.user;
            userPresenter = new UserPresenter(this);
            ActiveButton(btnHome);
            
        }

        public void LoadData()
        {
            LoadingFormUtils.Show(this);
            userPresenter.GetDoctors();

            lbFullName.Text = "Hi! " + user.FullName;
        }

        private void btnMyProfile_Click(object sender, EventArgs e)
        {
            frmViewProfile frm = new frmViewProfile();
            openChildForm(frm, btnProfile);
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
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                string doctorID = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                DialogResult dialogResult = MessageBox.Show("Do you want to book this doctor?", "Confirm", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    userPresenter.BookDoctor(doctorID);
                }
            }
        }

        private void btnViewDoctor_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                string doctorID = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                userPresenter.GetDoctorByID(doctorID);
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            LoginInfo.user = null;
            frmLogin frm = new frmLogin();
            frm.Show();
            Close();
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

        private void cbMajor_SelectedValueChanged(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
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
            dataGridView1.DataSource = dtDoctor;
            dataGridView1.Columns["idUser"].Visible = false;
            dataGridView1.Columns["majorID"].Visible = false;
            dataGridView1.Columns["idCertificate"].Visible = false;

            DataTable dtMajor = dsDoctor.Tables[1];
            DataRow dr = dtMajor.NewRow();
            dr["majorID"] = "";
            dr["name"] = "All";
            dtMajor.Rows.InsertAt(dr, 0);

            cbMajor.DisplayMember = "name";
            cbMajor.ValueMember = "majorID";
            cbMajor.DataSource = dtMajor;
            LoadingFormUtils.Close();
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

        public void BookDoctor(bool check)
        {
            if (check)
            {
                MessageBox.Show("Booked successful!\nWaiting for doctor confirming...", "Message");
            } else
            {
                MessageBox.Show("You already have another booking!", "Message");
            }
        }

        private void frmCustomer_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}