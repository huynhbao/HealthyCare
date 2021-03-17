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
    public static class LoadingFormUtils
    {
        static frmLoading wait;
        static Thread loadthread;

        public static void Show(Form parent)
        {
            loadthread = new Thread(new ParameterizedThreadStart(LoadingProcess));
            loadthread.Start(parent);
        }

        public static void Close()
        {
            if (wait != null)
            {
                wait.BeginInvoke(new ThreadStart(wait.CloseWaitForm));
                wait = null;
                loadthread = null;
            }
        }

        private static void LoadingProcess()
        {
            wait = new frmLoading();
            wait.ShowDialog();
        }

        private static void LoadingProcess(object parent)
        {
            Form parent1 = parent as Form;
            wait = new frmLoading(parent1);
            wait.ShowDialog();
        }
    }
}
