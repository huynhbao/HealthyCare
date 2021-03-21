
namespace HealthyCare.UI.User
{
    partial class frmEditProfile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditProfile));
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.lbEmail = new DarkUI.Controls.DarkLabel();
            this.btnSave = new DarkUI.Controls.DarkButton();
            this.lbParentForm = new DarkUI.Controls.DarkLabel();
            this.btnExit = new FontAwesome.Sharp.IconButton();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.txtFullname = new DarkUI.Controls.DarkTextBox();
            this.darkLabel6 = new DarkUI.Controls.DarkLabel();
            this.darkLabel7 = new DarkUI.Controls.DarkLabel();
            this.darkLabel8 = new DarkUI.Controls.DarkLabel();
            this.darkLabel9 = new DarkUI.Controls.DarkLabel();
            this.darkLabel10 = new DarkUI.Controls.DarkLabel();
            this.txtAddress = new DarkUI.Controls.DarkTextBox();
            this.txtPhone = new DarkUI.Controls.DarkTextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.darkLabel1 = new DarkUI.Controls.DarkLabel();
            this.panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.rbFemale.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rbFemale.Location = new System.Drawing.Point(413, 219);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(70, 21);
            this.rbFemale.TabIndex = 36;
            this.rbFemale.Text = "Female";
            this.rbFemale.UseVisualStyleBackColor = true;
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Checked = true;
            this.rbMale.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMale.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rbMale.Location = new System.Drawing.Point(317, 219);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(56, 21);
            this.rbMale.TabIndex = 37;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Male";
            this.rbMale.UseVisualStyleBackColor = true;
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lbEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.lbEmail.Location = new System.Drawing.Point(313, 298);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(96, 21);
            this.lbEmail.TabIndex = 39;
            this.lbEmail.Text = "darkLabel7";
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(394, 392);
            this.btnSave.Name = "btnSave";
            this.btnSave.Padding = new System.Windows.Forms.Padding(5);
            this.btnSave.Size = new System.Drawing.Size(89, 29);
            this.btnSave.TabIndex = 40;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lbParentForm
            // 
            this.lbParentForm.AutoSize = true;
            this.lbParentForm.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbParentForm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.lbParentForm.Location = new System.Drawing.Point(10, 6);
            this.lbParentForm.Name = "lbParentForm";
            this.lbParentForm.Size = new System.Drawing.Size(75, 17);
            this.lbParentForm.TabIndex = 1;
            this.lbParentForm.Text = "Edit Profile";
            // 
            // btnExit
            // 
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.btnExit.IconColor = System.Drawing.Color.White;
            this.btnExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnExit.IconSize = 25;
            this.btnExit.Location = new System.Drawing.Point(773, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(28, 25);
            this.btnExit.TabIndex = 20;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(9)))), ((int)(((byte)(9)))));
            this.panelTitleBar.Controls.Add(this.lbParentForm);
            this.panelTitleBar.Controls.Add(this.btnExit);
            this.panelTitleBar.Location = new System.Drawing.Point(0, 1);
            this.panelTitleBar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(801, 29);
            this.panelTitleBar.TabIndex = 41;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(0, 456);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(801, 65);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 42;
            this.pictureBox3.TabStop = false;
            // 
            // txtFullname
            // 
            this.txtFullname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.txtFullname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFullname.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtFullname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.txtFullname.Location = new System.Drawing.Point(317, 177);
            this.txtFullname.Name = "txtFullname";
            this.txtFullname.Size = new System.Drawing.Size(253, 23);
            this.txtFullname.TabIndex = 44;
            // 
            // darkLabel6
            // 
            this.darkLabel6.AutoSize = true;
            this.darkLabel6.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.darkLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkLabel6.Location = new System.Drawing.Point(190, 179);
            this.darkLabel6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.darkLabel6.Name = "darkLabel6";
            this.darkLabel6.Size = new System.Drawing.Size(72, 17);
            this.darkLabel6.TabIndex = 43;
            this.darkLabel6.Text = "FullName:";
            // 
            // darkLabel7
            // 
            this.darkLabel7.AutoSize = true;
            this.darkLabel7.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.darkLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkLabel7.Location = new System.Drawing.Point(202, 221);
            this.darkLabel7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.darkLabel7.Name = "darkLabel7";
            this.darkLabel7.Size = new System.Drawing.Size(60, 17);
            this.darkLabel7.TabIndex = 43;
            this.darkLabel7.Text = "Gender:";
            // 
            // darkLabel8
            // 
            this.darkLabel8.AutoSize = true;
            this.darkLabel8.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.darkLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkLabel8.Location = new System.Drawing.Point(202, 261);
            this.darkLabel8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.darkLabel8.Name = "darkLabel8";
            this.darkLabel8.Size = new System.Drawing.Size(61, 17);
            this.darkLabel8.TabIndex = 43;
            this.darkLabel8.Text = "Address:";
            // 
            // darkLabel9
            // 
            this.darkLabel9.AutoSize = true;
            this.darkLabel9.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.darkLabel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkLabel9.Location = new System.Drawing.Point(215, 302);
            this.darkLabel9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.darkLabel9.Name = "darkLabel9";
            this.darkLabel9.Size = new System.Drawing.Size(47, 17);
            this.darkLabel9.TabIndex = 43;
            this.darkLabel9.Text = "Email:";
            // 
            // darkLabel10
            // 
            this.darkLabel10.AutoSize = true;
            this.darkLabel10.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.darkLabel10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkLabel10.Location = new System.Drawing.Point(210, 346);
            this.darkLabel10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.darkLabel10.Name = "darkLabel10";
            this.darkLabel10.Size = new System.Drawing.Size(53, 17);
            this.darkLabel10.TabIndex = 43;
            this.darkLabel10.Text = "Phone:";
            // 
            // txtAddress
            // 
            this.txtAddress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAddress.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.txtAddress.Location = new System.Drawing.Point(317, 259);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(253, 23);
            this.txtAddress.TabIndex = 44;
            // 
            // txtPhone
            // 
            this.txtPhone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.txtPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPhone.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.txtPhone.Location = new System.Drawing.Point(317, 344);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(253, 23);
            this.txtPhone.TabIndex = 44;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::HealthyCare.Properties.Resources.app_logo;
            this.pictureBox2.Location = new System.Drawing.Point(372, 42);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(70, 70);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 46;
            this.pictureBox2.TabStop = false;
            // 
            // darkLabel1
            // 
            this.darkLabel1.AutoSize = true;
            this.darkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.darkLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkLabel1.Location = new System.Drawing.Point(334, 117);
            this.darkLabel1.Name = "darkLabel1";
            this.darkLabel1.Size = new System.Drawing.Size(149, 25);
            this.darkLabel1.TabIndex = 45;
            this.darkLabel1.Text = "Healthy Care";
            // 
            // frmEditProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(800, 522);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.darkLabel1);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtFullname);
            this.Controls.Add(this.darkLabel10);
            this.Controls.Add(this.darkLabel9);
            this.Controls.Add(this.darkLabel8);
            this.Controls.Add(this.darkLabel7);
            this.Controls.Add(this.darkLabel6);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lbEmail);
            this.Controls.Add(this.rbFemale);
            this.Controls.Add(this.rbMale);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmEditProfile";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmEditProfile";
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.RadioButton rbMale;
        private DarkUI.Controls.DarkLabel lbEmail;
        private DarkUI.Controls.DarkButton btnSave;
        private DarkUI.Controls.DarkLabel lbParentForm;
        private FontAwesome.Sharp.IconButton btnExit;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.PictureBox pictureBox3;
        private DarkUI.Controls.DarkTextBox txtFullname;
        private DarkUI.Controls.DarkLabel darkLabel6;
        private DarkUI.Controls.DarkLabel darkLabel7;
        private DarkUI.Controls.DarkLabel darkLabel8;
        private DarkUI.Controls.DarkLabel darkLabel9;
        private DarkUI.Controls.DarkLabel darkLabel10;
        private DarkUI.Controls.DarkTextBox txtAddress;
        private DarkUI.Controls.DarkTextBox txtPhone;
        private System.Windows.Forms.PictureBox pictureBox2;
        private DarkUI.Controls.DarkLabel darkLabel1;
    }
}