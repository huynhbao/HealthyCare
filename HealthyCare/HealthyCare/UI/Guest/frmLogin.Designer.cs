
namespace HealthyCare.UI.G
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.lbLogin = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.darkLabel1 = new DarkUI.Controls.DarkLabel();
            this.darkLabel2 = new DarkUI.Controls.DarkLabel();
            this.txtUsername = new DarkUI.Controls.DarkTextBox();
            this.txtPassword = new DarkUI.Controls.DarkTextBox();
            this.btnLogin = new DarkUI.Controls.DarkButton();
            this.btnRegister = new DarkUI.Controls.DarkButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // lbLogin
            // 
            this.lbLogin.AutoSize = true;
            this.lbLogin.Font = new System.Drawing.Font("Times New Roman", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLogin.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbLogin.Location = new System.Drawing.Point(153, 44);
            this.lbLogin.Name = "lbLogin";
            this.lbLogin.Size = new System.Drawing.Size(399, 73);
            this.lbLogin.TabIndex = 6;
            this.lbLogin.Text = "Healthy Care";
            this.lbLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(369, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 55);
            this.label1.TabIndex = 8;
            this.label1.Text = "Login";
            // 
            // darkLabel1
            // 
            this.darkLabel1.AutoSize = true;
            this.darkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.darkLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkLabel1.Location = new System.Drawing.Point(374, 243);
            this.darkLabel1.Name = "darkLabel1";
            this.darkLabel1.Size = new System.Drawing.Size(116, 25);
            this.darkLabel1.TabIndex = 9;
            this.darkLabel1.Text = "Username:";
            // 
            // darkLabel2
            // 
            this.darkLabel2.AutoSize = true;
            this.darkLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.darkLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkLabel2.Location = new System.Drawing.Point(374, 286);
            this.darkLabel2.Name = "darkLabel2";
            this.darkLabel2.Size = new System.Drawing.Size(112, 25);
            this.darkLabel2.TabIndex = 10;
            this.darkLabel2.Text = "Password:";
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.txtUsername.Location = new System.Drawing.Point(496, 250);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(149, 20);
            this.txtUsername.TabIndex = 11;
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.txtPassword.Location = new System.Drawing.Point(496, 286);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(149, 20);
            this.txtPassword.TabIndex = 12;
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(496, 329);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Padding = new System.Windows.Forms.Padding(5);
            this.btnLogin.Size = new System.Drawing.Size(149, 37);
            this.btnLogin.TabIndex = 13;
            this.btnLogin.Text = "Login";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.Location = new System.Drawing.Point(496, 384);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Padding = new System.Windows.Forms.Padding(5);
            this.btnRegister.Size = new System.Drawing.Size(149, 37);
            this.btnRegister.TabIndex = 14;
            this.btnRegister.Text = "Register";
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Location = new System.Drawing.Point(47, 153);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(283, 268);
            this.panel1.TabIndex = 15;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.ClientSize = new System.Drawing.Size(718, 513);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.darkLabel2);
            this.Controls.Add(this.darkLabel1);
            this.Controls.Add(this.lbLogin);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLogin";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbLogin;
        private System.Windows.Forms.Label label1;
        private DarkUI.Controls.DarkLabel darkLabel1;
        private DarkUI.Controls.DarkLabel darkLabel2;
        private DarkUI.Controls.DarkTextBox txtUsername;
        private DarkUI.Controls.DarkTextBox txtPassword;
        private DarkUI.Controls.DarkButton btnLogin;
        private DarkUI.Controls.DarkButton btnRegister;
        private System.Windows.Forms.Panel panel1;
    }
}

