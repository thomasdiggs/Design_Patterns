namespace Chain_of_Responsibility.Interfaces
{
    internal interface IHandler
    {
        public void HandleRequest(int request);
    }
}