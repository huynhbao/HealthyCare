using HealthyCare.UI.Guest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HealthyCare.Utils
{
    public class LoadingFormUtils
    {
        frmLoading wait;
        Thread loadThread;

        public void Show(Form parent)
        {
            loadThread = new Thread(new ParameterizedThreadStart(LoadingProcess));
            loadThread.Start(parent);
        }

        public void Show()
        {
            loadThread = new Thread(new ThreadStart(LoadingProcess));
            loadThread.Start();
        }

        public void Close()
        {
            if (wait != null)
            {
                wait.BeginInvoke(new ThreadStart(wait.CloseWaitForm));
                wait = null;
                loadThread = null;
            }
        }

        private void LoadingProcess()
        {
            wait = new frmLoading();
            wait.ShowDialog();
        }

        private void LoadingProcess(object parent)
        {
            Form parent1 = parent as Form;
            wait = new frmLoading(parent1);
            wait.ShowDialog();
        }
    }
}
