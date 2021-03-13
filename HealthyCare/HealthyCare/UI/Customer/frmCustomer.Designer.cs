
namespace HealthyCare.UI.Customer
{
    partial class frmCustomer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnView = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvDoctorList = new System.Windows.Forms.DataGridView();
            this.btnBook = new DarkUI.Controls.DarkButton();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.darkLabel1 = new DarkUI.Controls.DarkLabel();
            this.btnMyProfile = new DarkUI.Controls.DarkButton();
            this.button1 = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.pbHome = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.pnView.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoctorList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnView
            // 
            this.pnView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.pnView.Controls.Add(this.groupBox1);
            this.pnView.Location = new System.Drawing.Point(142, 0);
            this.pnView.Name = "pnView";
            this.pnView.Size = new System.Drawing.Size(825, 501);
            this.pnView.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listView1);
            this.groupBox1.Controls.Add(this.dgvDoctorList);
            this.groupBox1.Controls.Add(this.btnBook);
            this.groupBox1.Controls.Add(this.richTextBox1);
            this.groupBox1.Controls.Add(this.darkLabel1);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(10, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(800, 474);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Home";
            // 
            // dgvDoctorList
            // 
            this.dgvDoctorList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDoctorList.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDoctorList.Location = new System.Drawing.Point(114, 68);
            this.dgvDoctorList.MultiSelect = false;
            this.dgvDoctorList.Name = "dgvDoctorList";
            this.dgvDoctorList.ReadOnly = true;
            this.dgvDoctorList.Size = new System.Drawing.Size(661, 98);
            this.dgvDoctorList.TabIndex = 4;
            // 
            // btnBook
            // 
            this.btnBook.Location = new System.Drawing.Point(700, 421);
            this.btnBook.Name = "btnBook";
            this.btnBook.Padding = new System.Windows.Forms.Padding(5);
            this.btnBook.Size = new System.Drawing.Size(75, 23);
            this.btnBook.TabIndex = 3;
            this.btnBook.Text = "Book";
            this.btnBook.Click += new System.EventHandler(this.btnBook_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(114, 314);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(661, 101);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // darkLabel1
            // 
            this.darkLabel1.AutoSize = true;
            this.darkLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkLabel1.Location = new System.Drawing.Point(26, 317);
            this.darkLabel1.Name = "darkLabel1";
            this.darkLabel1.Size = new System.Drawing.Size(60, 13);
            this.darkLabel1.TabIndex = 1;
            this.darkLabel1.Text = "Description";
            // 
            // btnMyProfile
            // 
            this.btnMyProfile.Location = new System.Drawing.Point(35, 110);
            this.btnMyProfile.Name = "btnMyProfile";
            this.btnMyProfile.Padding = new System.Windows.Forms.Padding(5);
            this.btnMyProfile.Size = new System.Drawing.Size(75, 23);
            this.btnMyProfile.TabIndex = 4;
            this.btnMyProfile.Text = "My Profile";
            this.btnMyProfile.Click += new System.EventHandler(this.btnMyProfile_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button1.Location = new System.Drawing.Point(-1, 444);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 42);
            this.button1.TabIndex = 7;
            this.button1.Text = "Logout";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnHome.Location = new System.Drawing.Point(-1, 164);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(147, 42);
            this.btnHome.TabIndex = 9;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // pbHome
            // 
            this.pbHome.BackColor = System.Drawing.Color.Transparent;
            this.pbHome.Image = global::HealthyCare.Properties.Resources.home_2_64;
            this.pbHome.Location = new System.Drawing.Point(12, 168);
            this.pbHome.Name = "pbHome";
            this.pbHome.Size = new System.Drawing.Size(32, 32);
            this.pbHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbHome.TabIndex = 10;
            this.pbHome.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::HealthyCare.Properties.Resources.logout_64;
            this.pictureBox2.Location = new System.Drawing.Point(12, 447);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HealthyCare.Properties.Resources.user_icon;
            this.pictureBox1.Location = new System.Drawing.Point(24, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 92);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(114, 172);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(661, 136);
            this.listView1.TabIndex = 5;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // frmCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(964, 498);
            this.Controls.Add(this.pbHome);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnMyProfile);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pnView);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnHome);
            this.Name = "frmCustomer";
            this.Text = "frmCustomer";
            this.pnView.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoctorList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnView;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DarkUI.Controls.DarkButton btnMyProfile;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.PictureBox pbHome;
        private DarkUI.Controls.DarkButton btnBook;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private DarkUI.Controls.DarkLabel darkLabel1;
        private System.Windows.Forms.DataGridView dgvDoctorList;
        private System.Windows.Forms.ListView listView1;
    }
}