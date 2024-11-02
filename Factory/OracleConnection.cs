namespace Factory
{
    internal class OracleConnection : IConnection
    {
        public string GetDescription()
        {
            return "Oracle Connection";
        }
    }
}