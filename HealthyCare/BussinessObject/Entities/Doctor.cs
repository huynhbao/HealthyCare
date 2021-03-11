using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessObject.Entities
{
    public class Doctor : User
    {
        public Certificate Certificate;
    }

    public class Certificate
    {
        public int certificateID { get; set; }
        public string name { get; set; }

        public Certificate(int certificateID, string name)
        {
            this.certificateID = certificateID;
            this.name = name;
        }
    }
}
