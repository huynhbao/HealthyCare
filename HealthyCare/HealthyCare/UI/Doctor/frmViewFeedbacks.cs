using DarkUI.Forms;
using HealthyCare.Presenters;
using HealthyCare.Utils;
using HealthyCare.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HealthyCare.UI.Doctor
{
    
    public partial class frmViewFeedbacks : DarkForm, IViewFeedback
    {
        ViewBookingPresenter viewBookingPresenter = null;
        DataSet dsFeedback;
        public frmViewFeedbacks()
        {
            InitializeComponent();
            viewBookingPresenter = new ViewBookingPresenter(this);
            LoadData();
        }

        public void GetFeedback(DataSet dsFeedback)
        {
            this.dsFeedback = dsFeedback;
            dgvFeedback.DataSource = dsFeedback.Tables[0];
        }
        private void LoadData()
        {
            viewBookingPresenter.GetFeedback();
        }

<<<<<<< HEAD
=======
        private void dgvFeedback_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvFeedback.Columns[e.ColumnIndex].Name.Equals("points"))
            {
                int points = (int)e.Value;
                switch (points)
                {
                    case 1:
                        e.Value = "♥";
                        break;
                    case 2:
                        e.Value = "♥♥";
                        break;
                    case 3:
                        e.Value = "♥♥♥";
                        break;
                    case 4:
                        e.Value = "♥♥♥♥";
                        break;
                    case 5:
                        e.Value = "♥♥♥♥♥";
                        break;

                }
            }
        }
>>>>>>> 5d068b6aa3eccd0504b8c675d25bd6034eecfe1c
    }
}
