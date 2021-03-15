
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
            this.dgvUser = new System.Windows.Forms.DataGridView();
            this.btnDeleteUser = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCreateDoctor
            // 
            this.btnCreateDoctor.Location = new System.Drawing.Point(58, 379);
            this.btnCreateDoctor.Name = "btnCreateDoctor";
            this.btnCreateDoctor.Size = new System.Drawing.Size(113, 23);
            this.btnCreateDoctor.TabIndex = 0;
            this.btnCreateDoctor.Text = "Create Doctor";
            this.btnCreateDoctor.UseVisualStyleBackColor = true;
            this.btnCreateDoctor.Click += new System.EventHandler(this.btnCreateDoctor_Click);
            // 
            // dgvUser
            // 
            this.dgvUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUser.Location = new System.Drawing.Point(12, 31);
            this.dgvUser.Name = "dgvUser";
            this.dgvUser.Size = new System.Drawing.Size(776, 190);
            this.dgvUser.TabIndex = 1;
            this.dgvUser.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvUser_CellFormatting);
            this.dgvUser.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvUser_DataBindingComplete);
            // 
            // btnDeleteUser
            // 
            this.btnDeleteUser.Location = new System.Drawing.Point(254, 379);
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteUser.TabIndex = 2;
            this.btnDeleteUser.Text = "Delete User";
            this.btnDeleteUser.UseVisualStyleBackColor = true;
            this.btnDeleteUser.Click += new System.EventHandler(this.btnDeleteUser_Click);
            // 
            // frmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDeleteUser);
            this.Controls.Add(this.dgvUser);
            this.Controls.Add(this.btnCreateDoctor);
            this.Name = "frmAdmin";
            this.Text = "frmAdmin";
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCreateDoctor;
        private System.Windows.Forms.DataGridView dgvUser;
        private System.Windows.Forms.Button btnDeleteUser;
    }
}