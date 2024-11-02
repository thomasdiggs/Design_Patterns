namespace Factory.Interfaces
{
    internal interface IConnectionFactory
    {
        IConnection CreateConnection(string type);
    }
}