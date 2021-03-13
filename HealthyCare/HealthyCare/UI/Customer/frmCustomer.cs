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

    public partial class frmCustomer : DarkForm, IUser
    {
        User user = null;
        UserPresenter userPresenter = null;
        private List<Doctor> list = null;
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
            list = userPresenter.ListDoctor();

            listView1.View = View.Details;
            listView1.Columns.Add("Full Name");
            listView1.Columns.Add("Phone");
            listView1.Columns.Add("Address");
            listView1.Columns[0].Width = 215;
            listView1.Columns[1].Width = 215;
            listView1.Columns[2].Width = 215;
            ImageList lstviewItemImageList = new ImageList();

            foreach (Doctor doctor in list)
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
                listView1.SmallImageList = lstviewItemImageList;*/
                listView1.Items.Add(item1);
            }

            lbFullName.Text = "Hi! " + user.FullName;
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
            string doctorID = listView1.SelectedItems[0].ImageKey;
        }

        private void btnViewDoctor_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                string doctorID = listView1.SelectedItems[0].ImageKey;
                Doctor doctor = list.SingleOrDefault(a => a.UserID == doctorID);
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


        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
