namespace Chain_of_Responsibility
{
    internal class HandlerC : IHandler
    {
        private const int HANDLER_C_REQUEST = 2;
        private IHandler _nextHandler;

        public HandlerC(IHandler nextHandler)
        {
            _nextHandler = nextHandler;
        }

        public void HandleRequest(int request)
        {
            if (request == HANDLER_C_REQUEST)
            {
                Console.WriteLine($"HandlerC handled request {request}");
            }
            else
            {
                _nextHandler.HandleRequest(request);
            }
        }
    }
}