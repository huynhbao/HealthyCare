using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessObject
{
    public class AdminData
    {
        public DataSet GetData()
        {
            string sql = "select idUser, fullName, address, email, phone, gender, status, idRole " +
                "from Users; Select idFeedback FROM Feedback";
            //SqlParameter RoleIDParam = new SqlParameter("@idRole", "3");
            DataSet dt = DataProvider.ExecuteQueryWithDataSet(sql, CommandType.Text);
            return dt;
        }
        public bool DeleteUser(String userID, int status)
        {
            string SQL = "Update  Users set status=@staus WHERE idUser=@idUser";

            SqlParameter BookingIDParam = new SqlParameter("@idUser", userID);
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
    }
}
