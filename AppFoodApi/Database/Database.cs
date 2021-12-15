using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace AppFoodApi.Database
{
    public class Database
    {
        public static DataTable ReadTable(string StoreProcedureName, Dictionary<string, object> para = null)
        {
            try
            {
                //result variable 
                DataTable resultTable = new DataTable();

                //create connection
                string SqlconnectionString = ConfigurationManager.ConnectionStrings["AppFood"].ConnectionString;
                SqlConnection connection = new SqlConnection(SqlconnectionString);

                connection.Open();

                //Create and assign propeties for command
                SqlCommand sqlcmd = connection.CreateCommand();
                sqlcmd.Connection = connection;
                sqlcmd.CommandText = StoreProcedureName;
                sqlcmd.CommandType = CommandType.StoredProcedure;

                if (para != null)
                {
                    foreach (KeyValuePair<string, object> data in para)
                    {
                        if (data.Value == null)
                        {
                            sqlcmd.Parameters.AddWithValue("@" + data.Key, DBNull.Value);
                        }
                        else
                        {
                            sqlcmd.Parameters.AddWithValue("@" + data.Key, data.Value);

                        }
                    }
                }
                SqlDataAdapter sqlDA = new SqlDataAdapter();
                sqlDA.SelectCommand = sqlcmd;
                sqlDA.Fill(resultTable);

                connection.Close();

                return resultTable;
            }
            catch
            {
                return null;
            }
        }
    }
}