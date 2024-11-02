namespace Chain_of_Responsibility
{
    internal class HandlerA : IHandler
    {
        private const int HANDLER_A_REQUEST = 1;
        private IHandler _nextHandler;

        public HandlerA(IHandler nextHandler)
        {
            _nextHandler = nextHandler;
        }

        public void HandleRequest(int request)
        {
            if (request == HANDLER_A_REQUEST)
            {
                Console.WriteLine($"HandlerA handled request {request}");
            }
            else
            {
                _nextHandler.HandleRequest(request);
            }
        }
    }
}