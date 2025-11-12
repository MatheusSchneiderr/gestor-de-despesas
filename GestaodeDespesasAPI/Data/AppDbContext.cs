using System.Configuration;
using MySql.Data.MySqlClient;

namespace GestaodeDespesasAPI.Data
{
    public class AppDbContext
    {
        private string connStr;
        public AppDbContext()
        {
            connStr = ConfigurationManager.ConnectionStrings["DbContext"].ConnectionString;
        }

        public MySqlConnection CreateConnection()
        {
            return new MySqlConnection(connStr);
        }
    }
}