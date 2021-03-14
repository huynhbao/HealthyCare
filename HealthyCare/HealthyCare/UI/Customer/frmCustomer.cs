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

    public partial class frmCustomer : DarkForm, IUser
    {
        User user = null;
        UserPresenter userPresenter = null;
        private DataSet dsDoctor;
        private DataTable dtDoctor;
        private Form activeForm = null;
        private Button activeButton = null;

        string IUser.UserID { get; set; }
        string IUser.Password { get; set; }
        string IUser.FullName { get; set; }
        bool IUser.Gender { get; set; }
        string IUser.Email { get; set; }
        string IUser.Address { get; set; }
        string IUser.Phone { get; set; }

        public frmCustomer()
        {
            InitializeComponent();
            user = LoginInfo.user;
            userPresenter = new UserPresenter(this);
            ActiveButton(btnHome);
            LoadData();
        }

        public void LoadData()
        {
            dsDoctor = userPresenter.GetDoctors();

            listView1.View = View.Details;
            listView1.Columns.Add("Full Name");
            listView1.Columns.Add("Phone");
            listView1.Columns.Add("Address");
            listView1.Columns[0].Width = 215;
            listView1.Columns[1].Width = 215;
            listView1.Columns[2].Width = 215;
            ImageList lstviewItemImageList = new ImageList();

            dtDoctor = dsDoctor.Tables[0];
            dataGridView1.DataSource = dtDoctor;
            foreach (DataRow row in dtDoctor.Rows)
            {
                string doctorID = row["idUser"].ToString();
                lstviewItemImageList.ImageSize = new Size(40, 40);
                lstviewItemImageList.Images.Add(doctorID, Properties.Resources.user_icon);
                listView1.SmallImageList = lstviewItemImageList;

                ListViewItem item1 = new ListViewItem();
                item1.Text = row["fullName"].ToString();
                item1.ImageKey = doctorID;

                for (int i = 1; i < dtDoctor.Columns.Count; i++)
                {
                    item1.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = row["phone"].ToString() });
                    item1.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = row["address"].ToString() });
                }
                listView1.Items.Add(item1);
            }

            DataTable dtMajor = dsDoctor.Tables[1];
            DataRow dr = dtMajor.NewRow();
            dr["majorID"] = "";
            dr["name"] = "Select Khoa";
            dtMajor.Rows.InsertAt(dr, 0);

            //cbMajor.SelectedIndex = 0;
            cbMajor.DisplayMember = "name";
            cbMajor.ValueMember = "majorID";
            cbMajor.DataSource = dtMajor;


            /*foreach (Doctor doctor in list)
            {
                string doctorID = doctor.UserID;
                lstviewItemImageList.ImageSize = new Size(40, 40);
                lstviewItemImageList.Images.Add(doctorID, Properties.Resources.user_icon);
                listView1.SmallImageList = lstviewItemImageList;

                ListViewItem item1 = new ListViewItem();
                item1.Text = doctor.FullName;
                item1.ImageKey = doctorID;
                item1.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = doctor.Phone });
                item1.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = doctor.Address });
                /*lstviewItem = new ListViewItem(arr);
                lstviewItemImageList.ImageSize = new Size(40, 40);
                lstviewItemImageList.Images.Add(doctorID, Properties.Resources.doctor_logo);
                listView1.SmallImageList = lstviewItemImageList;
                listView1.Items.Add(item1);
            }*/

            lbFullName.Text = "Hi! " + user.FullName;
            dataGridView1.DataSource = dtDoctor;
            dataGridView1.Columns["idUser"].Visible = false;
            dataGridView1.Columns["majorID"].Visible = false;
            dataGridView1.Columns["idCertificate"].Visible = false;
            //dataGridView1.Columns["Role"].Visible = false;
            //dataGridView1.Columns["Status"].Visible = false;
        }

        private void btnMyProfile_Click(object sender, EventArgs e)
        {
            ActiveButton(btnProfile);
            frmViewProfile frm = new frmViewProfile();
            openChildForm(frm);
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

        private void openChildForm(Form childForm)
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
                    bool check = userPresenter.BookDoctor(doctorID);
                    if (check)
                    {
                        MessageBox.Show("Booked successful!\nWaiting for doctor confirming...", "Message");
                    }
                }
            }
        }

        private void btnViewDoctor_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                string doctorID = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                Doctor doctor = userPresenter.GetDoctorByID(doctorID);
                frmDoctorDetail frm = new frmDoctorDetail(doctor);
                frm.ShowDialog();
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
            ActiveButton(btnHistory);
            frmHistory frm = new frmHistory();
            openChildForm(frm);
        }
    }
}