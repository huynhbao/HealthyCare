using BussinessObject;
using BussinessObject.Entities;
using HealthyCare.Views;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthyCare.Presenters
{

    public class AdminPresenter
    {
        AdminData adminData = new AdminData();
        IAdmin adminView;
        User user = null;

        public event WaitCallBack OnDataLoading;
        public event WaitCompletedCallBack OnDataLoadingCompleted;

        public AdminPresenter(IAdmin view)
        {
            user = LoginInfo.user;
            adminView = view;

        }
        public void GetData()
        {
            if (OnDataLoading != null)
            {
                OnDataLoading();
            }
            DataSet data = adminData.GetData();
            if (OnDataLoadingCompleted != null)
            {
                OnDataLoadingCompleted();
            }
            adminView.GetData(data);
        }

        public void DeleteUser(String userID)
        {
            bool check = adminData.DeleteUser(userID, 0);
            adminView.DeleteUser(check);
        }
    }
}
