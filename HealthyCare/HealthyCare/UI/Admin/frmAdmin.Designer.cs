
namespace HealthyCare.UI.Admin
{
    partial class frmAdmin
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
            this.pnView = new System.Windows.Forms.Panel();
            this.darkLabel4 = new DarkUI.Controls.DarkLabel();
            this.darkLabel3 = new DarkUI.Controls.DarkLabel();
            this.darkLabel2 = new DarkUI.Controls.DarkLabel();
            this.lbFeedback = new DarkUI.Controls.DarkLabel();
            this.lbTotalUsers = new DarkUI.Controls.DarkLabel();
            this.lbTotalDoctors = new DarkUI.Controls.DarkLabel();
            this.iconButton5 = new FontAwesome.Sharp.IconButton();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.btnMinimize = new FontAwesome.Sharp.IconButton();
            this.lbParentForm = new DarkUI.Controls.DarkLabel();
            this.btnExit = new FontAwesome.Sharp.IconButton();
            this.darkLabel1 = new DarkUI.Controls.DarkLabel();
            this.lbFullName = new DarkUI.Controls.DarkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnHome = new FontAwesome.Sharp.IconButton();
            this.btnManageUsers = new FontAwesome.Sharp.IconButton();
            this.btnManageDoctors = new FontAwesome.Sharp.IconButton();
            this.btnLogout = new FontAwesome.Sharp.IconButton();
            this.pnView.SuspendLayout();
            this.panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnView
            // 
            this.pnView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.pnView.Controls.Add(this.darkLabel4);
            this.pnView.Controls.Add(this.darkLabel3);
            this.pnView.Controls.Add(this.darkLabel2);
            this.pnView.Controls.Add(this.lbFeedback);
            this.pnView.Controls.Add(this.lbTotalUsers);
            this.pnView.Controls.Add(this.lbTotalDoctors);
            this.pnView.Controls.Add(this.iconButton5);
            this.pnView.Controls.Add(this.iconButton2);
            this.pnView.Controls.Add(this.iconButton1);
            this.pnView.Location = new System.Drawing.Point(173, 0);
            this.pnView.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.pnView.Name = "pnView";
            this.pnView.Size = new System.Drawing.Size(952, 617);
            this.pnView.TabIndex = 3;
            // 
            // darkLabel4
            // 
            this.darkLabel4.AutoSize = true;
            this.darkLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkLabel4.Location = new System.Drawing.Point(905, 73);
            this.darkLabel4.Name = "darkLabel4";
            this.darkLabel4.Size = new System.Drawing.Size(32, 16);
            this.darkLabel4.TabIndex = 13;
            this.darkLabel4.Text = "Time";
            // 
            // darkLabel3
            // 
            this.darkLabel3.AutoSize = true;
            this.darkLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkLabel3.Location = new System.Drawing.Point(905, 45);
            this.darkLabel3.Name = "darkLabel3";
            this.darkLabel3.Size = new System.Drawing.Size(35, 16);
            this.darkLabel3.TabIndex = 13;
            this.darkLabel3.Text = "Date";
            // 
            // darkLabel2
            // 
            this.darkLabel2.AutoSize = true;
            this.darkLabel2.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.darkLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkLabel2.Location = new System.Drawing.Point(366, 180);
            this.darkLabel2.Name = "darkLabel2";
            this.darkLabel2.Size = new System.Drawing.Size(190, 36);
            this.darkLabel2.TabIndex = 12;
            this.darkLabel2.Text = "DASHBOARD";
            // 
            // lbFeedback
            // 
            this.lbFeedback.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(53)))), ((int)(((byte)(55)))));
            this.lbFeedback.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbFeedback.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFeedback.ForeColor = System.Drawing.Color.LightGreen;
            this.lbFeedback.Location = new System.Drawing.Point(681, 350);
            this.lbFeedback.Name = "lbFeedback";
            this.lbFeedback.Size = new System.Drawing.Size(124, 25);
            this.lbFeedback.TabIndex = 11;
            this.lbFeedback.Text = "0";
            this.lbFeedback.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbTotalUsers
            // 
            this.lbTotalUsers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(53)))), ((int)(((byte)(55)))));
            this.lbTotalUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbTotalUsers.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalUsers.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lbTotalUsers.Location = new System.Drawing.Point(157, 351);
            this.lbTotalUsers.Name = "lbTotalUsers";
            this.lbTotalUsers.Size = new System.Drawing.Size(124, 25);
            this.lbTotalUsers.TabIndex = 1;
            this.lbTotalUsers.Text = "0";
            this.lbTotalUsers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbTotalDoctors
            // 
            this.lbTotalDoctors.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(53)))), ((int)(((byte)(55)))));
            this.lbTotalDoctors.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbTotalDoctors.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.lbTotalDoctors.ForeColor = System.Drawing.Color.DeepPink;
            this.lbTotalDoctors.Location = new System.Drawing.Point(422, 351);
            this.lbTotalDoctors.Name = "lbTotalDoctors";
            this.lbTotalDoctors.Size = new System.Drawing.Size(124, 25);
            this.lbTotalDoctors.TabIndex = 11;
            this.lbTotalDoctors.Text = "0";
            this.lbTotalDoctors.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // iconButton5
            // 
            this.iconButton5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(53)))), ((int)(((byte)(55)))));
            this.iconButton5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton5.FlatAppearance.BorderSize = 0;
            this.iconButton5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(53)))), ((int)(((byte)(55)))));
            this.iconButton5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(53)))), ((int)(((byte)(55)))));
            this.iconButton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton5.ForeColor = System.Drawing.Color.Transparent;
            this.iconButton5.IconChar = FontAwesome.Sharp.IconChar.Comments;
            this.iconButton5.IconColor = System.Drawing.Color.LightGreen;
            this.iconButton5.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton5.IconSize = 35;
            this.iconButton5.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.iconButton5.Location = new System.Drawing.Point(681, 269);
            this.iconButton5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.iconButton5.Name = "iconButton5";
            this.iconButton5.Padding = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.iconButton5.Size = new System.Drawing.Size(124, 125);
            this.iconButton5.TabIndex = 10;
            this.iconButton5.Text = "Feedback";
            this.iconButton5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.iconButton5.UseVisualStyleBackColor = false;
            // 
            // iconButton2
            // 
            this.iconButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(53)))), ((int)(((byte)(55)))));
            this.iconButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton2.FlatAppearance.BorderSize = 0;
            this.iconButton2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(53)))), ((int)(((byte)(55)))));
            this.iconButton2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(53)))), ((int)(((byte)(55)))));
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton2.ForeColor = System.Drawing.Color.Transparent;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.UserMd;
            this.iconButton2.IconColor = System.Drawing.Color.DeepPink;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 35;
            this.iconButton2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.iconButton2.Location = new System.Drawing.Point(422, 269);
            this.iconButton2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Padding = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.iconButton2.Size = new System.Drawing.Size(124, 125);
            this.iconButton2.TabIndex = 10;
            this.iconButton2.Text = "Doctors";
            this.iconButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.iconButton2.UseVisualStyleBackColor = false;
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(53)))), ((int)(((byte)(55)))));
            this.iconButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(53)))), ((int)(((byte)(55)))));
            this.iconButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(53)))), ((int)(((byte)(55)))));
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.ForeColor = System.Drawing.Color.Transparent;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.iconButton1.IconColor = System.Drawing.Color.DodgerBlue;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 35;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.iconButton1.Location = new System.Drawing.Point(157, 270);
            this.iconButton1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Padding = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.iconButton1.Size = new System.Drawing.Size(124, 125);
            this.iconButton1.TabIndex = 0;
            this.iconButton1.Text = "Users";
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.iconButton1.UseVisualStyleBackColor = false;
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(9)))), ((int)(((byte)(9)))));
            this.panelTitleBar.Controls.Add(this.btnMinimize);
            this.panelTitleBar.Controls.Add(this.lbParentForm);
            this.panelTitleBar.Controls.Add(this.btnExit);
            this.panelTitleBar.Location = new System.Drawing.Point(1, 1);
            this.panelTitleBar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(1123, 29);
            this.panelTitleBar.TabIndex = 10;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // btnMinimize
            // 
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.btnMinimize.IconColor = System.Drawing.Color.White;
            this.btnMinimize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMinimize.IconSize = 25;
            this.btnMinimize.Location = new System.Drawing.Point(1061, 0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(28, 25);
            this.btnMinimize.TabIndex = 19;
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // lbParentForm
            // 
            this.lbParentForm.AutoSize = true;
            this.lbParentForm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.lbParentForm.Location = new System.Drawing.Point(10, 6);
            this.lbParentForm.Name = "lbParentForm";
            this.lbParentForm.Size = new System.Drawing.Size(68, 16);
            this.lbParentForm.TabIndex = 1;
            this.lbParentForm.Text = "darkLabel3";
            // 
            // btnExit
            // 
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.btnExit.IconColor = System.Drawing.Color.White;
            this.btnExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnExit.IconSize = 25;
            this.btnExit.Location = new System.Drawing.Point(1092, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(28, 25);
            this.btnExit.TabIndex = 20;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // darkLabel1
            // 
            this.darkLabel1.AutoSize = true;
            this.darkLabel1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.darkLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkLabel1.Location = new System.Drawing.Point(23, 52);
            this.darkLabel1.Name = "darkLabel1";
            this.darkLabel1.Size = new System.Drawing.Size(133, 23);
            this.darkLabel1.TabIndex = 16;
            this.darkLabel1.Text = "Administrator";
            // 
            // lbFullName
            // 
            this.lbFullName.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFullName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.lbFullName.Location = new System.Drawing.Point(12, 197);
            this.lbFullName.Name = "lbFullName";
            this.lbFullName.Size = new System.Drawing.Size(155, 63);
            this.lbFullName.TabIndex = 15;
            this.lbFullName.Text = "darkLabel3";
            this.lbFullName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HealthyCare.Properties.Resources.admin_logo;
            this.pictureBox1.Location = new System.Drawing.Point(35, 87);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(104, 102);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // btnHome
            // 
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnHome.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.btnHome.IconColor = System.Drawing.Color.Azure;
            this.btnHome.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnHome.IconSize = 35;
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(2, 269);
            this.btnHome.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnHome.Name = "btnHome";
            this.btnHome.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.btnHome.Size = new System.Drawing.Size(179, 52);
            this.btnHome.TabIndex = 0;
            this.btnHome.Text = "Home";
            this.btnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnManageUsers
            // 
            this.btnManageUsers.FlatAppearance.BorderSize = 0;
            this.btnManageUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageUsers.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageUsers.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnManageUsers.IconChar = FontAwesome.Sharp.IconChar.UserCog;
            this.btnManageUsers.IconColor = System.Drawing.Color.Azure;
            this.btnManageUsers.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnManageUsers.IconSize = 35;
            this.btnManageUsers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManageUsers.Location = new System.Drawing.Point(2, 331);
            this.btnManageUsers.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnManageUsers.Name = "btnManageUsers";
            this.btnManageUsers.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.btnManageUsers.Size = new System.Drawing.Size(179, 52);
            this.btnManageUsers.TabIndex = 1;
            this.btnManageUsers.Text = "Manage Users";
            this.btnManageUsers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnManageUsers.UseVisualStyleBackColor = true;
            this.btnManageUsers.Click += new System.EventHandler(this.btnManageUsers_Click);
            // 
            // btnManageDoctors
            // 
            this.btnManageDoctors.FlatAppearance.BorderSize = 0;
            this.btnManageDoctors.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageDoctors.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageDoctors.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnManageDoctors.IconChar = FontAwesome.Sharp.IconChar.UserMd;
            this.btnManageDoctors.IconColor = System.Drawing.Color.Azure;
            this.btnManageDoctors.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnManageDoctors.IconSize = 35;
            this.btnManageDoctors.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManageDoctors.Location = new System.Drawing.Point(2, 393);
            this.btnManageDoctors.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnManageDoctors.Name = "btnManageDoctors";
            this.btnManageDoctors.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.btnManageDoctors.Size = new System.Drawing.Size(179, 52);
            this.btnManageDoctors.TabIndex = 2;
            this.btnManageDoctors.Text = "Manage Doctors";
            this.btnManageDoctors.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnManageDoctors.UseVisualStyleBackColor = true;
            this.btnManageDoctors.Click += new System.EventHandler(this.btnManageDoctors_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btnLogout.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnLogout.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.btnLogout.IconColor = System.Drawing.Color.Azure;
            this.btnLogout.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLogout.IconSize = 35;
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(2, 454);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.btnLogout.Size = new System.Drawing.Size(179, 52);
            this.btnLogout.TabIndex = 18;
            this.btnLogout.Text = "Logout";
            this.btnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // frmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(1125, 613);
            this.Controls.Add(this.darkLabel1);
            this.Controls.Add(this.lbFullName);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pnView);
            this.Controls.Add(this.btnManageDoctors);
            this.Controls.Add(this.btnManageUsers);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.btnLogout);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAdmin";
            this.Load += new System.EventHandler(this.frmAdmin_Load);
            this.pnView.ResumeLayout(false);
            this.pnView.PerformLayout();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnView;
        private System.Windows.Forms.Panel panelTitleBar;
        private DarkUI.Controls.DarkLabel lbParentForm;
        private DarkUI.Controls.DarkLabel darkLabel1;
        private DarkUI.Controls.DarkLabel lbFullName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton btnHome;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton btnManageUsers;
        private DarkUI.Controls.DarkLabel lbTotalUsers;
        private DarkUI.Controls.DarkLabel lbTotalDoctors;
        private DarkUI.Controls.DarkLabel lbFeedback;
        private FontAwesome.Sharp.IconButton iconButton5;
        private DarkUI.Controls.DarkLabel darkLabel4;
        private DarkUI.Controls.DarkLabel darkLabel3;
        private DarkUI.Controls.DarkLabel darkLabel2;
        private FontAwesome.Sharp.IconButton btnManageDoctors;
        private FontAwesome.Sharp.IconButton btnLogout;
        private FontAwesome.Sharp.IconButton btnMinimize;
        private FontAwesome.Sharp.IconButton btnExit;
    }
}