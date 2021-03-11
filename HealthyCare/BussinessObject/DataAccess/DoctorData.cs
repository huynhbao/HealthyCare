using BussinessObject.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessObject.DataAccess
{
    public class DoctorData
    {
        public bool Register(Doctor doctor)
        {
            string SqlCertificate = "INSERT Certificate(name) OUTPUT INSERTED.idCertificate VALUES(@name)";
            SqlParameter certificateName = new SqlParameter("@name", doctor.Certificate.name);
            doctor.Certificate.certificateID = DataProvider.ExecuteNonQueryLastInsertedId(SqlCertificate, CommandType.Text, certificateName);
            string SQL = "INSERT Users(idUser, password, fullName, address, email, phone, gender, idRole, idCertificate) VALUES(@idUser, @password, @fullName, @address, @email, @phone, @gender, @idRole, @idCertificate)";

            SqlParameter idUser = new SqlParameter("@idUser", doctor.UserID);
            SqlParameter password = new SqlParameter("@password", doctor.Password);
            SqlParameter fullName = new SqlParameter("@fullName", doctor.FullName);
            SqlParameter address = new SqlParameter("@address", doctor.Address);
            SqlParameter email = new SqlParameter("@email", doctor.Email);
            SqlParameter phone = new SqlParameter("@phone", doctor.Phone);
            SqlParameter gender = new SqlParameter("@gender", doctor.Gender);
            SqlParameter idRole = new SqlParameter("@idRole", "2");
            SqlParameter idCertificate = new SqlParameter("@idCertificate", doctor.Certificate.certificateID);
            try
            {
                return DataProvider.ExecuteNonQuery(SQL, CommandType.Text, idUser, password, fullName, address, email, phone, gender, idRole, idCertificate);
            }
            catch (SqlException se)
            {
                throw new Exception(se.Message);
            }
        }
    }
}
