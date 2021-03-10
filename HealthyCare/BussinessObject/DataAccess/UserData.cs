using BussinessObject.Entities;
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
        string strConnection = ConfigurationManager.ConnectionStrings["LangBam4.0"].ConnectionString;

        public User Login(string UserID, string Password)
        {
            User user = null;

            SqlConnection cnn = new SqlConnection(strConnection);
            string SQL = "select fullName " +
                "from Users where idUser=@ID AND password=@Password";
            SqlCommand cmd = new SqlCommand(SQL, cnn);
            cmd.Parameters.AddWithValue("@ID", UserID);
            cmd.Parameters.AddWithValue("@Password", Password);
            try
            {
                if (cnn.State == ConnectionState.Closed)
                {
                    cnn.Open();
                }
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    if (reader.HasRows)
                    {
                        if (user == null)
                        {
                            user = new User();
                        }
                        user.FullName = reader[0].ToString();
                    }
                }
            }
            catch (SqlException se)
            {
                throw new Exception(se.Message);
            }
            finally
            {
                cnn.Close();
            }
            return user;
        }

        public bool Register(User user)
        {
            SqlConnection cnn = new SqlConnection(strConnection);
            string SQL = "INSERT Users VALUES(@idUser, @password, @fullName, @address, @email, @phone, @idGender, @idRole)";
            SqlCommand cmd = new SqlCommand(SQL, cnn);
            cmd.Parameters.AddWithValue("@idUser", user.UserID);
            cmd.Parameters.AddWithValue("@password", user.Password);
            cmd.Parameters.AddWithValue("@fullName", user.FullName);
            cmd.Parameters.AddWithValue("@address", user.Address);
            cmd.Parameters.AddWithValue("@email", user.Email);
            cmd.Parameters.AddWithValue("@phone", user.Phone);
            cmd.Parameters.AddWithValue("@idGender", user.Gender);
            cmd.Parameters.AddWithValue("@idRole", "R1");

            if (cnn.State == ConnectionState.Closed)
            {
                cnn.Open();
            }

            int count = cmd.ExecuteNonQuery();
            return (count > 0);
        }
    }
}
