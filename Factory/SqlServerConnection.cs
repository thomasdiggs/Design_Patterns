namespace Factory
{
    internal class SqlServerConnection : IConnection
    {
        public string GetDescription()
        {
            return "SQL Server Connection";
        }
    }
}