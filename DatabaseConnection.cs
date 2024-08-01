using Oracle.ManagedDataAccess.Client;

namespace ProjectTouristManagmentSystem
{

    internal class DatabaseConnection
    {
        private static DatabaseConnection instance;
        private OracleConnection connection;

        private DatabaseConnection()
        {
            string connectionString = "User Id=YOURID;Password=YOURPASSWORD;Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=calvin.humber.ca)(PORT=1521))(CONNECT_DATA=(SID=grok)))";
            connection = new OracleConnection(connectionString);
        }

        public static DatabaseConnection GetInstance()
        {

            //Singleton Design Patterns
            if (instance == null)
            {
                if (instance == null)
                {
                    instance = new DatabaseConnection();
                }
            }
            return instance;
        }

        public OracleConnection GetConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
            return connection;
        }
    }

}
