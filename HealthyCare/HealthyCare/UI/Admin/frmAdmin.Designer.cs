
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
            this.btnCreateDoctor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCreateDoctor
            // 
            this.btnCreateDoctor.Location = new System.Drawing.Point(161, 140);
            this.btnCreateDoctor.Name = "btnCreateDoctor";
            this.btnCreateDoctor.Size = new System.Drawing.Size(75, 23);
            this.btnCreateDoctor.TabIndex = 0;
            this.btnCreateDoctor.Text = "Create Doctor";
            this.btnCreateDoctor.UseVisualStyleBackColor = true;
            this.btnCreateDoctor.Click += new System.EventHandler(this.btnCreateDoctor_Click);
            // 
            // frmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCreateDoctor);
            this.Name = "frmAdmin";
            this.Text = "frmAdmin";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCreateDoctor;
    }
}