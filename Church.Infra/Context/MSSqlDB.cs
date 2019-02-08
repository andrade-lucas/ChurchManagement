using System.Data;
using System.Data.SqlClient;

namespace Church.Infra.Context
{
    public class MSSqlDB : IDB
    {
        private SqlConnection DB;
        private string connectionString;

        public MSSqlDB(IDbConfiguration config)
        {
            connectionString = config.ConnectionString;
        }

        public void Dispose()
        {
            DB.Close();
            DB.Dispose();
        }

        public IDbConnection GetCon()
        {
            DB = new SqlConnection(connectionString);
            return DB;
        }
    }
}
