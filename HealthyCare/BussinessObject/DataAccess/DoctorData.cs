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

        private Major GetMajor(string majorID)
        {
            Major major = null;

            string sql = "select name " +
                "from Major where majorID=@majorID";
            SqlParameter majorIDParam = new SqlParameter("@majorID", majorID);
            SqlDataReader rd = DataProvider.ExecuteQueryWithDataReader(sql, CommandType.Text, majorIDParam);
            if (rd.HasRows)
            {
                if (rd.Read())
                {
                    major = new Major
                    {
                        MajorID = majorID,
                        Name = rd[0].ToString(),
                    };
                }
            }

            return major;
        }

        public DataSet GetDoctors()
        {

            string sql = "SELECT idUser, fullName, address, email, phone, gender, idCertificate, majorID " +
                "FROM Users where idRole=@idRole; SELECT majorID, name FROM Major";
            SqlParameter RoleIDParam = new SqlParameter("@idRole", "2");
            DataSet dt = DataProvider.ExecuteQueryWithDataSet(sql, CommandType.Text, RoleIDParam);
            return dt;
        }
        public DataSet GetBooking(string idDoctor)
        {
            string sql = "SELECT idBooking, b.idUser, u.fullName, bookingDate, b.status from Booking b, Users u where idDoctor=@idDoctor and b.status=1 and b.idUser=u.idUser ORDER BY bookingDate DESC";
            SqlParameter DoctorIDParam = new SqlParameter("@idDoctor", idDoctor);
            DataSet dt = DataProvider.ExecuteQueryWithDataSet(sql, CommandType.Text, DoctorIDParam);
            return dt;
        }

        public User GetUserInformationByID(string UserID)
        {
            User user = null;

            string sql = "select fullName, address, email, phone, gender, Count(CASE WHEN b.status = 1 THEN 1 END) from Users u, Booking b where u.idUser=@UserID AND u.idUser=b.idUser AND u.status = 1 GROUP BY fullName, address, email, phone, gender";
            SqlParameter UserIDParam = new SqlParameter("@UserID", UserID);
            SqlDataReader rd = DataProvider.ExecuteQueryWithDataReader(sql, CommandType.Text, UserIDParam);
            if (rd.HasRows)
            {
                if (rd.Read())
                {
                    user = new User()
                    {
                        UserID = UserID,
                        FullName = rd[0].ToString(),
                        Address = rd[1].ToString(),
                        Email = rd[2].ToString(),
                        Phone = rd[3].ToString(),
                        Gender = bool.Parse(rd[4].ToString()),
                        TotalBooking = int.Parse(rd[5].ToString()),
                    };
                }
            }
            return user;
        }


        public Doctor GetDoctorByID(string DoctorID)
        {
            Doctor doctor = null;

            string sql = "select fullName, address, email, phone, gender, idCertificate, majorID " +
                "from Users where idUser=@DoctorID AND status = 1";
            SqlParameter DoctorIDParam = new SqlParameter("@DoctorID", DoctorID);
            SqlDataReader rd = DataProvider.ExecuteQueryWithDataReader(sql, CommandType.Text, DoctorIDParam);
            if (rd.HasRows)
            {
                if (rd.Read())
                {
                    doctor = new Doctor()
                    {
                        UserID = DoctorID,
                        FullName = rd[0].ToString(),
                        Address = rd[1].ToString(),
                        Email = rd[2].ToString(),
                        Phone = rd[3].ToString(),
                        Gender = bool.Parse(rd[4].ToString()),
                        Certificate = GetCertificate(int.Parse(rd[5].ToString())),
                        Major = GetMajor(rd[6].ToString())
                    };
                }
            }
            return doctor;
        }

        public int GetNumOfBooking(string DoctorID)
        {
            int result = 0;

            string sql = "select count(*) from Booking where idDoctor=@idUser AND status = 3";
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

        public bool AcceptBooking(string idBooking)
        {
            string SQL = "Update Booking set status=2 WHERE idBooking=@idBooking";

            SqlParameter idBookingParam = new SqlParameter("@idBooking", idBooking);
            try
            {
                return DataProvider.ExecuteNonQuery(SQL, CommandType.Text, idBookingParam);
            }
            catch (SqlException se)
            {
                throw new Exception(se.Message);
            }
        }

        public bool RejectBooking(string idBooking)
        {
            string SQL = "Update Booking set status=4 WHERE idBooking=@idBooking";

            SqlParameter idBookingParam = new SqlParameter("@idBooking", idBooking);
            try
            {
                return DataProvider.ExecuteNonQuery(SQL, CommandType.Text, idBookingParam);
            }
            catch (SqlException se)
            {
                throw new Exception(se.Message);
            }
        }

        public bool CheckWaitingBooking(string UserID)
        {
            bool result = true;

            string sql = "select status " +
                "from Booking where idUser=@idUser";
            SqlParameter UserIDIDParam = new SqlParameter("@idUser", UserID);
            SqlDataReader rd = DataProvider.ExecuteQueryWithDataReader(sql, CommandType.Text, UserIDIDParam);
            while (rd.Read())
            {
                if (int.Parse(rd["status"].ToString()) != 1)
                {
                    result = false;
                    break;
                }
            }

            return result;
        }
    }
}
