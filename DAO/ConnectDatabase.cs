#region

using System.Configuration;
using System.Data;
using System.Data.SqlClient;

#endregion

namespace DAO
{
    public class ConnectDatabase
    {
        private static readonly string ConnString =
            ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;

        public static SqlConnection Conn = new SqlConnection(ConnString);

        public static string GetConnString()
        {
            return ConnString;
        }

        public static DataSet Getdataset(string sql, string tenbang, SqlConnection conn)
        {
            var ds = new DataSet();
            var da = new SqlDataAdapter(sql, conn);
            da.Fill(ds, tenbang);
            return ds;
        }
    }
}