using BussinessObject.DataAccess;
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
        public User Login(string UserID, string Password)
        {
            User user = null;
            string sql = "select fullName, address, email, phone, gender, idRole, status " +
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
                        UserID = UserID,
                        FullName = rd[0].ToString(),
                        Address = rd[1].ToString(),
                        Email = rd[2].ToString(),
                        Phone = rd[3].ToString(),
                        Gender = bool.Parse(rd[4].ToString()),
                        Role = Role(rd[5].ToString()),
                        Status = bool.Parse(rd[6].ToString()),
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

        public int Register(User user)
        {
            bool checkExist = false;
            string SQLCheck = "SELECT idUser FROM Users WHERE idUser=@idUser";
            SqlParameter idUserParam = new SqlParameter("@idUser", user.UserID);
            SqlDataReader rd = DataProvider.ExecuteQueryWithDataReader(SQLCheck, CommandType.Text, idUserParam);
            if (rd.HasRows)
            {
                if (rd.Read())
                {
                    checkExist = true;
                }
            }

            if (!checkExist)
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
                    DataProvider.ExecuteNonQuery(SQL, CommandType.Text, idUser, password, fullName, address, email, phone, gender, idRole);
                    return 0;
                }
                catch (SqlException)
                {
                    return 2;
                }
            }
            else
            {
                return 1;
            }
        }

        public bool UpadteProfile(User user)
        {
            string SQL = "Update Users set fullName=@fullName, address=@address, phone=@phone, gender=@gender WHERE idUser=@idUser";

            SqlParameter idUser = new SqlParameter("@idUser", user.UserID);
            SqlParameter fullName = new SqlParameter("@fullName", user.FullName);
            SqlParameter address = new SqlParameter("@address", user.Address);
            SqlParameter phone = new SqlParameter("@phone", user.Phone);
            SqlParameter gender = new SqlParameter("@gender", user.Gender);
            try
            {
                return DataProvider.ExecuteNonQuery(SQL, CommandType.Text, idUser, fullName, address, phone, gender);
            }
            catch (SqlException se)
            {
                throw new Exception(se.Message);
            }
        }

        public bool BookDoctor(string DoctorID, string UserID, DateTime now)
        {
            string SQL = "INSERT Booking(idUser, idDoctor, bookingDate, status) VALUES(@idUser, @idDoctor, @bookingDate, @status)";

            SqlParameter idUser = new SqlParameter("@idUser", UserID);
            SqlParameter idDoctor = new SqlParameter("@idDoctor", DoctorID);
            SqlParameter bookingDate = new SqlParameter("@bookingDate", now);
            SqlParameter status = new SqlParameter("@status", 1);
            try
            {
                return DataProvider.ExecuteNonQuery(SQL, CommandType.Text, idUser, idDoctor, bookingDate, status);
            }
            catch (SqlException se)
            {
                throw new Exception(se.Message);
            }
        }

        public bool CheckPreviousBooking(string UserID)
        {
            bool result = false;

            string sql = "select status " +
                "from Booking where idUser=@idUser";
            SqlParameter UserIDIDParam = new SqlParameter("@idUser", UserID);
            SqlDataReader rd = DataProvider.ExecuteQueryWithDataReader(sql, CommandType.Text, UserIDIDParam);
            while (rd.Read())
            {
                if (int.Parse(rd["status"].ToString()) == 1)
                {
                    result = true;
                    break;
                }
            }

            return result;
        }

        public bool CheckPreviousFeedback(string UserID, int bookingID)
        {
            bool result = false;

            string sql = "SELECT idFeedback from Feedback WHERE idUser =@idUser AND idBooking=@bookingID";
            SqlParameter UserIDIDParam = new SqlParameter("@idUser", UserID);
            SqlParameter idBooking = new SqlParameter("@bookingID", bookingID);
            SqlDataReader rd = DataProvider.ExecuteQueryWithDataReader(sql, CommandType.Text, UserIDIDParam, idBooking);
            while (rd.Read())
            {
                if(rd.HasRows)
                {
                    result = true;
                }
            }

            return result;
        }

        public bool Feedback(String UserID, int bookingID, string comment, int value)
        {
            string SQL = "INSERT Feedback(comment, idUser, points, idBooking) VALUES(@comment, @idUser, @points, @idBooking)";

            SqlParameter idUser = new SqlParameter("@idUser", UserID);
            SqlParameter commentParam = new SqlParameter("@comment", comment);
            SqlParameter pointsParam = new SqlParameter("@points", value);
            SqlParameter idBookingParam = new SqlParameter("@idBooking", bookingID);
            try
            {
                return DataProvider.ExecuteNonQuery(SQL, CommandType.Text, commentParam, idUser, pointsParam, idBookingParam);
            }
            catch (SqlException se)
            {
                throw new Exception(se.Message);
            }
        }

        public bool CheckPassword(string UserID, String curPw)
        {
            bool result = false;

            string sql = "SELECT idUser FROM Users WHERE idUser =@idUser AND password =@password";
            SqlParameter UserIDIDParam = new SqlParameter("@idUser", UserID);
            SqlParameter password = new SqlParameter("@password", curPw);
            SqlDataReader rd = DataProvider.ExecuteQueryWithDataReader(sql, CommandType.Text, UserIDIDParam, password);
            while (rd.Read())
            {
                if (rd.HasRows)
                {
                    result = true;
                }
            }

            return result;
        }

        public bool ChangePassword(string UserID, String newPw)
        {
            string SQL = "Update Users set password=@password WHERE idUser=@idUser";

            SqlParameter userID = new SqlParameter("@idUser", UserID);
            SqlParameter password = new SqlParameter("@password", newPw);
            try
            {
                return DataProvider.ExecuteNonQuery(SQL, CommandType.Text, userID, password);
            }
            catch (SqlException se)
            {
                throw new Exception(se.Message);
            }
        }

        public DataSet GetHistory(string UserID)
        {
            string sql = "SELECT idBooking, bookingDate, idDoctor, fullName, b.status FROM Booking b, Users u WHERE b.idUser=@idUser AND b.idDoctor=u.idUser ORDER BY status ASC";
            SqlParameter RoleIDParam = new SqlParameter("@idUser", UserID);
            DataSet dt = DataProvider.ExecuteQueryWithDataSet(sql, CommandType.Text, RoleIDParam);
            return dt;
        }

        public bool SetStatusBooking(int BookingID, int status)
        {
            string SQL = "Update Booking set status=@staus WHERE idBooking=@idBooking";

            SqlParameter BookingIDParam = new SqlParameter("@idBooking", BookingID);
            SqlParameter StatusParam = new SqlParameter("@staus", status);
            try
            {
                return DataProvider.ExecuteNonQuery(SQL, CommandType.Text, BookingIDParam, StatusParam);
            }
            catch (SqlException se)
            {
                throw new Exception(se.Message);
            }
        }

        public Booking GetLatestBooking(User user)
        {
            Booking result = null;

            string sql = "SELECT TOP 1 idBooking, status, idDoctor, bookingDate FROM Booking WHERE idUser=@idUser AND status != 3 AND status != 4";
            SqlParameter UserIDIDParam = new SqlParameter("@idUser", user.UserID);
            SqlDataReader rd = DataProvider.ExecuteQueryWithDataReader(sql, CommandType.Text, UserIDIDParam);
            if (rd.Read())
            {
                if (rd.HasRows)
                {
                    DoctorData doctorData = new DoctorData();
                    Doctor doctor = doctorData.GetDoctorByID(rd["idDoctor"].ToString());
                    result = new Booking
                    {
                        BookingID = int.Parse(rd["idBooking"].ToString()),
                        Status = int.Parse(rd["status"].ToString()),
                        Time = DateTime.Parse(rd["bookingDate"].ToString()),
                        User = user,
                        Doctor = doctor
                    };
                }
            }

            return result;
        }

        public Booking GetBookingInformation(string BookingID)
        {
            Booking result = null;

            string sql = "SELECT status, idDoctor, idUser, bookingDate FROM Booking WHERE idBooking=@idBooking";
            SqlParameter UserIDIDParam = new SqlParameter("@idBooking", BookingID);
            SqlDataReader rd = DataProvider.ExecuteQueryWithDataReader(sql, CommandType.Text, UserIDIDParam);
            if (rd.Read())
            {
                if (rd.HasRows)
                {
                    DoctorData doctorData = new DoctorData();
                    Doctor doctor = doctorData.GetDoctorByID(rd["idDoctor"].ToString());
                    User user = doctorData.GetUserInformationByID(rd["idUser"].ToString());
                    result = new Booking
                    {
                        BookingID = int.Parse(BookingID),
                        Status = int.Parse(rd["status"].ToString()),
                        Time = DateTime.Parse(rd["bookingDate"].ToString()),
                        Doctor = doctor,
                        User = user
                    };
                }
            }

            return result;
        }
    }
}
