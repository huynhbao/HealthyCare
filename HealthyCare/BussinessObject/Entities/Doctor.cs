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
        public Major Major;
    }

    public class Certificate
    {
        public int CertificateID { get; set; }
        public string Name { get; set; }

        public Certificate(int CertificateID, string Name)
        {
            this.CertificateID = CertificateID;
            this.Name = Name;
        }

        public Certificate()
        {
        }
    }

    public class Major
    {
        public string MajorID { get; set; }
        public string Name { get; set; }

        public Major(string MajorID, string Name)
        {
            this.MajorID = MajorID;
            this.Name = Name;
        }

        public Major()
        {
        }

    }
}
