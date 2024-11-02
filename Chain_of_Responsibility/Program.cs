global using Chain_of_Responsibility;
global using Chain_of_Responsibility.Interfaces;


HandlerFinal handlerFinal = new();
HandlerA handlerA = new(handlerFinal);
HandlerB handlerB = new(handlerA);
HandlerC handlerC = new(handlerB);

handlerC.HandleRequest(1);
handlerC.HandleRequest(2);
handlerC.HandleRequest(3);
handlerC.HandleRequest(4);