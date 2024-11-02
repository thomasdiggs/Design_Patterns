namespace Observer
{
    internal class SubscriberB : IObserver
    {
        public void OnNotify(string operation, string record)
        {
            Console.WriteLine($"SubscriberB: {operation} - {record}");
        }
    }
}