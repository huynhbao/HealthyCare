using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthyCare.Views
{
    public interface IViewFeedback
    {
        void GetFeedback(DataSet dsFeedback);
    }
}
