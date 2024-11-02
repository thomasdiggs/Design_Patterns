namespace Observer
{
    internal class Channel : ISubject
    {
        private List<IObserver> _observers;
        private string _operation = string.Empty;
        private string _record = string.Empty;

        public Channel()
        {
            _observers = new List<IObserver>();
        }

        public void Attach(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            _observers.Remove(observer);
        }

        public void Upload(string operation, string record)
        {
            _operation = operation;
            _record = record;

            Notify();
        }

        public void Notify()
        {
            foreach (var observer in _observers)
            {
                observer.OnNotify(_operation, _record);
            }
        }
    }
}