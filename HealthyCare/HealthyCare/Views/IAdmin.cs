
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthyCare.Views
{
    public interface IAdmin
    {
        void GetUsers(DataSet data);
        void DeleteUser(bool check);
    }
}
