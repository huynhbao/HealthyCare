using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public static class DataProvider
{
    public static string getConnectionString()
    {
        string strConnection = ConfigurationManager.
            ConnectionStrings["LangBam4.0"].ConnectionString;
        return strConnection;
    }

    //Execute Query
    public static DataSet ExecuteQueryWithDataSet(string strSQL,
        CommandType cmdType,
        params SqlParameter[] param)
    {
        SqlConnection cnn = new SqlConnection(getConnectionString());
        SqlCommand cmd = new SqlCommand(strSQL, cnn);
        cmd.CommandType = cmdType;
        cmd.Parameters.AddRange(param);
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        da.Fill(ds);
        return ds;
    }
    public static SqlDataReader ExecuteQueryWithDataReader(string strSQL,
        CommandType cmdType, params SqlParameter[] param)
    {
        SqlDataReader rd = null;
        SqlConnection cnn = new SqlConnection(getConnectionString());
        SqlCommand cmd = new SqlCommand(strSQL, cnn);
        cmd.CommandType = cmdType;
        cmd.Parameters.AddRange(param);
        try
        {
            cnn.Open();
            rd = cmd.ExecuteReader(CommandBehavior.CloseConnection);
        }
        catch (Exception ex)
        {
            throw new Exception("Error : " + ex.Message);
        }
        return rd;
    }
    //ExecuteNonQuery
    public static bool ExecuteNonQuery(string strSQL,
        CommandType cmdType, params SqlParameter[] paramList)
    {
        bool result = false;
        SqlConnection cnn = new SqlConnection(getConnectionString());
        SqlCommand cmd = new SqlCommand(strSQL, cnn);
        cmd.CommandType = cmdType;
        cmd.Parameters.AddRange(paramList);
        try
        {
            cnn.Open();
            result = cmd.ExecuteNonQuery() > 0;
        }
        catch (Exception ex)
        {
            throw new Exception("Error : " + ex.Message);
        }
        finally
        {
            cnn.Close();
        }
        return result;
    }

    public static int ExecuteNonQueryLastInsertedId(string strSQL,
        CommandType cmdType, params SqlParameter[] paramList)
    {
        int result = 0;
        SqlConnection cnn = new SqlConnection(getConnectionString());
        SqlCommand cmd = new SqlCommand(strSQL, cnn);
        cmd.CommandType = cmdType;
        cmd.Parameters.AddRange(paramList);
        try
        {
            cnn.Open();
            result = (int)cmd.ExecuteScalar();
        }
        catch (Exception ex)
        {
            throw new Exception("Error : " + ex.Message);
        }
        finally
        {
            cnn.Close();
        }
        return result;
    }
}

