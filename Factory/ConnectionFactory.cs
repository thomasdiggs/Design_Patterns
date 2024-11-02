namespace Factory
{
    internal class ConnectionFactory : IConnectionFactory
    {
        public IConnection CreateConnection(string type)
        {
            switch (type)
            {
                case "SqlServer":
                    return new SqlServerConnection();
                case "Oracle":
                    return new OracleConnection();
                default:
                    return new DefaultConnection();
            }
        }
    }
}