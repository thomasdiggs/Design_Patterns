namespace Chain_of_Responsibility
{
    internal class HandlerFinal : IHandler
    {
        public void HandleRequest(int request)
        {
            Console.WriteLine($"HandlerFinal handled request {request}");
        }
    }
}