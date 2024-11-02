namespace Observer.Interfaces
{
    internal interface IObserver
    {
        void OnNotify(string operation, string record);
    }
}