using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthyCare.Views
{
    public interface IProfileDoctor
    {
        void GetCertificate(String certificate);
        void GetMajor(String major);
    }
}
