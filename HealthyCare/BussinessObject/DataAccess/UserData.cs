﻿using BussinessObject.Entities;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessObject
{
    public class UserData
    {
        public User Login(string UserID, string Password)
        {
            User user = null;
            string sql = "select fullName, address, email, phone, gender, idRole " +
                "from Users where idUser=@ID AND password=@Password";
            SqlParameter UserIDParam = new SqlParameter("@ID", UserID);
            SqlParameter PasswordParam = new SqlParameter("@Password", Password);
            SqlDataReader rd = DataProvider.ExecuteQueryWithDataReader(sql, CommandType.Text, UserIDParam, PasswordParam);
            if (rd.HasRows)
            {
                if (rd.Read())
                {
                    user = new User()
                    {
                        FullName = rd[0].ToString(),
                        Address = rd[1].ToString(),
                        Email = rd[2].ToString(),
                        Phone = rd[3].ToString(),
                        Gender = bool.Parse(rd[4].ToString()),
                        Role = Role(rd[5].ToString()),
                    };
                }
            }

            return user;
        }

        private Role Role(string idRole)
        {
            Role role = null;

            string sql = "select nameRole " +
                "from Roles where idRole=@ID";
            SqlParameter RoleIDParam = new SqlParameter("@ID", idRole);
            SqlDataReader rd = DataProvider.ExecuteQueryWithDataReader(sql, CommandType.Text, RoleIDParam);
            if (rd.HasRows)
            {
                if (rd.Read())
                {
                    role = new Role()
                    {
                        RoleID = idRole,
                        RoleName = rd[0].ToString(),
                    };
                }
            }

            return role;
        }

        public bool Register(User user)
        {
            string SQL = "INSERT Users(idUser, password, fullName, address, email, phone, gender, idRole) VALUES(@idUser, @password, @fullName, @address, @email, @phone, @gender, @idRole)";

            SqlParameter idUser = new SqlParameter("@idUser", user.UserID);
            SqlParameter password = new SqlParameter("@password", user.Password);
            SqlParameter fullName = new SqlParameter("@fullName", user.FullName);
            SqlParameter address = new SqlParameter("@address", user.Address);
            SqlParameter email = new SqlParameter("@email", user.Email);
            SqlParameter phone = new SqlParameter("@phone", user.Phone);
            SqlParameter gender = new SqlParameter("@gender", user.Gender);
            SqlParameter idRole = new SqlParameter("@idRole", "3");
            try
            {
                return DataProvider.ExecuteNonQuery(SQL, CommandType.Text, idUser, password, fullName, address, email, phone, gender, idRole);
            }
            catch (SqlException se)
            {
                throw new Exception(se.Message);
            }
        }
    }
}
