﻿using BussinessObject.Entities;
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

            string sql = "select idUser, fullName, address, email, phone, gender, idCertificate, majorID " +
                "from Users where idRole=@idRole; SELECT majorID, name FROM Major";
            SqlParameter RoleIDParam = new SqlParameter("@idRole", "2");
            DataSet dt = DataProvider.ExecuteQueryWithDataSet(sql, CommandType.Text, RoleIDParam);
            return dt;
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
