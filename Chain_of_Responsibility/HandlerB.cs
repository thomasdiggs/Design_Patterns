namespace Chain_of_Responsibility
{
    internal class HandlerB : IHandler
    {
        private const int HANDLER_B_REQUEST = 2;
        private IHandler _nextHandler;

        public HandlerB(IHandler nextHandler)
        {
            _nextHandler = nextHandler;
        }

        public void HandleRequest(int request)
        {
            if (request == HANDLER_B_REQUEST)
            {
                Console.WriteLine($"HandlerB handled request {request}");
            }
            else
            {
                _nextHandler.HandleRequest(request);
            }
        }
    }
}