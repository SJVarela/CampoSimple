using System.Data.SqlClient;

namespace DataAccess.Connection
{
    public class SQLDbConnection
    {
        public static SqlConnection GetConnection()
        {
            return new SqlConnection();
        }

    }
}
