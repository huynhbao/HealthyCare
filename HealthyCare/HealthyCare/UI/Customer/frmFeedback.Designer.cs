
namespace HealthyCare.UI.Customer
{
    partial class frmFeedback
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFeedback));
            this.txtRating = new Bunifu.Framework.UI.BunifuRating();
            this.comment = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnFeedback = new Bunifu.Framework.UI.BunifuThinButton2();
            this.txtComment = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtRating
            // 
            this.txtRating.BackColor = System.Drawing.Color.Transparent;
            this.txtRating.ForeColor = System.Drawing.Color.SeaGreen;
            this.txtRating.Location = new System.Drawing.Point(247, 83);
            this.txtRating.Name = "txtRating";
            this.txtRating.Size = new System.Drawing.Size(316, 50);
            this.txtRating.TabIndex = 0;
            this.txtRating.Value = 0;
            // 
            // comment
            // 
            this.comment.AutoSize = true;
            this.comment.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comment.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.comment.Location = new System.Drawing.Point(127, 193);
            this.comment.Name = "comment";
            this.comment.Size = new System.Drawing.Size(114, 27);
            this.comment.TabIndex = 2;
            this.comment.Text = "Comment:";
            // 
            // btnFeedback
            // 
            this.btnFeedback.ActiveBorderThickness = 1;
            this.btnFeedback.ActiveCornerRadius = 20;
            this.btnFeedback.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnFeedback.ActiveForecolor = System.Drawing.Color.White;
            this.btnFeedback.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnFeedback.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.btnFeedback.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFeedback.BackgroundImage")));
            this.btnFeedback.ButtonText = "Feedback";
            this.btnFeedback.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFeedback.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFeedback.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnFeedback.IdleBorderThickness = 1;
            this.btnFeedback.IdleCornerRadius = 20;
            this.btnFeedback.IdleFillColor = System.Drawing.Color.White;
            this.btnFeedback.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnFeedback.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnFeedback.Location = new System.Drawing.Point(311, 323);
            this.btnFeedback.Margin = new System.Windows.Forms.Padding(5);
            this.btnFeedback.Name = "btnFeedback";
            this.btnFeedback.Size = new System.Drawing.Size(181, 41);
            this.btnFeedback.TabIndex = 3;
            this.btnFeedback.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnFeedback.Click += new System.EventHandler(this.btnFeedback_Click);
            // 
            // txtComment
            // 
            this.txtComment.Location = new System.Drawing.Point(247, 193);
            this.txtComment.Multiline = true;
            this.txtComment.Name = "txtComment";
            this.txtComment.Size = new System.Drawing.Size(316, 85);
            this.txtComment.TabIndex = 4;
            // 
            // frmFeedback
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtComment);
            this.Controls.Add(this.btnFeedback);
            this.Controls.Add(this.comment);
            this.Controls.Add(this.txtRating);
            this.Name = "frmFeedback";
            this.Text = "frmFeedback";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuRating txtRating;
        private Bunifu.Framework.UI.BunifuCustomLabel comment;
        private Bunifu.Framework.UI.BunifuThinButton2 btnFeedback;
        private System.Windows.Forms.TextBox txtComment;
    }
}