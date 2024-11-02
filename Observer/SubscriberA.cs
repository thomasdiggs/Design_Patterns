namespace Observer
{
    internal class SubscriberA : IObserver
    {
        public void OnNotify(string operation, string record)
        {
            Console.WriteLine($"SubscriberA: {operation} - {record}");
        }
    }
}