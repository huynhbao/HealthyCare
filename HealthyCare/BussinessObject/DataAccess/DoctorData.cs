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
            SqlParameter certificateName = new SqlParameter("@name", doctor.Certificate.Name);
            doctor.Certificate.CertificateID = DataProvider.ExecuteNonQueryLastInsertedId(SqlCertificate, CommandType.Text, certificateName);
            string SQL = "INSERT Users(idUser, password, fullName, address, email, phone, gender, idRole, idCertificate) VALUES(@idUser, @password, @fullName, @address, @email, @phone, @gender, @idRole, @idCertificate)";

            SqlParameter idUser = new SqlParameter("@idUser", doctor.UserID);
            SqlParameter password = new SqlParameter("@password", doctor.Password);
            SqlParameter fullName = new SqlParameter("@fullName", doctor.FullName);
            SqlParameter address = new SqlParameter("@address", doctor.Address);
            SqlParameter email = new SqlParameter("@email", doctor.Email);
            SqlParameter phone = new SqlParameter("@phone", doctor.Phone);
            SqlParameter gender = new SqlParameter("@gender", doctor.Gender);
            SqlParameter idRole = new SqlParameter("@idRole", "2");
            SqlParameter idCertificate = new SqlParameter("@idCertificate", doctor.Certificate.CertificateID);
            try
            {
                return DataProvider.ExecuteNonQuery(SQL, CommandType.Text, idUser, password, fullName, address, email, phone, gender, idRole, idCertificate);
            }
            catch (SqlException se)
            {
                throw new Exception(se.Message);
            }
        }

        private Certificate GetCertificate(int idCertificate)
        {
            Certificate certificate = null;

            string sql = "select name " +
                "from Certificate where idCertificate=@idCertificate";
            SqlParameter idCertificateParam = new SqlParameter("@idCertificate", idCertificate);
            SqlDataReader rd = DataProvider.ExecuteQueryWithDataReader(sql, CommandType.Text, idCertificateParam);
            if (rd.HasRows)
            {
                if (rd.Read())
                {
                    certificate = new Certificate
                    {
                        CertificateID = idCertificate,
                        Name = rd[0].ToString(),
                    };
                }
            }

            return certificate;
        }

        public List<Doctor> GetDoctorList()
        {
            List<Doctor> result = null;

            string sql = "select idUser, fullName, address, email, phone, gender, idCertificate " +
                "from Users where idRole=@idRole";
            SqlParameter RoleIDParam = new SqlParameter("@idRole", "2");
            SqlDataReader rd = DataProvider.ExecuteQueryWithDataReader(sql, CommandType.Text, RoleIDParam);
            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    Doctor doctor = new Doctor
                    {
                        UserID = rd[0].ToString(),
                        FullName = rd[1].ToString(),
                        Gender = bool.Parse(rd[5].ToString()),
                        Email = rd[3].ToString(),
                        Address = rd[2].ToString(),
                        Phone = rd[4].ToString(),
                        Certificate = GetCertificate(int.Parse(rd[6].ToString())),
                    };
                    if (result == null)
                    {
                        result = new List<Doctor>();
                    }
                    result.Add(doctor);
                }
            }
            return result;
        }

        public int GetNumOfBooking(string DoctorID)
        {
            int result = 0;

            string sql = "select count(*) from Booking where idUser=@idUser";
            SqlParameter DoctorIDParam = new SqlParameter("@idUser", DoctorID);
            SqlDataReader rd = DataProvider.ExecuteQueryWithDataReader(sql, CommandType.Text, DoctorIDParam);
            if (rd.HasRows)
            {
                if (rd.Read())
                {
                    result = int.Parse(rd[0].ToString());
                }
            }
            return result;
        }
    }
}
