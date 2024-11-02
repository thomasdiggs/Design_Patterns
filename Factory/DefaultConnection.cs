namespace Factory
{
    internal class DefaultConnection : IConnection
    {
        public string GetDescription()
        {
            return "Default Connection";
        }
    }
}