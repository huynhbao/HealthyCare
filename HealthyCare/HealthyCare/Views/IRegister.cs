using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthyCare.Views
{
    interface IRegister : IUser
    {
        void Register(int status);
    }
}
