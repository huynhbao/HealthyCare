
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
            this.btnMyProfile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMyProfile
            // 
            this.btnMyProfile.Location = new System.Drawing.Point(877, 12);
            this.btnMyProfile.Name = "btnMyProfile";
            this.btnMyProfile.Size = new System.Drawing.Size(75, 23);
            this.btnMyProfile.TabIndex = 0;
            this.btnMyProfile.Text = "My Profile";
            this.btnMyProfile.UseVisualStyleBackColor = true;
            this.btnMyProfile.Click += new System.EventHandler(this.btnMyProfile_Click);
            // 
            // frmCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 640);
            this.Controls.Add(this.btnMyProfile);
            this.Name = "frmCustomer";
            this.Text = "frmCustomer";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMyProfile;
    }
}