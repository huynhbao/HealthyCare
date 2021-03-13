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
        public int CertificateID { get; set; }
        public string Name { get; set; }

        public Certificate(int CertificateID, string name)
        {
            this.CertificateID = CertificateID;
            this.Name = name;
        }

        public Certificate()
        {
        }
    }
}
