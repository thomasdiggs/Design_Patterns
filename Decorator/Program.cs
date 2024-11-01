global using Decorator;
global using Decorator.Interfaces;
global using Decorator.Models;


IComponent component = new BasicComponent();
Console.WriteLine($"{component.GetDescription()} : ${component.GetPrice()}");

component = new FirstDecorator(component);
Console.WriteLine($"{component.GetDescription()} : ${component.GetPrice()}");

component = new SecondDecorator(component);
Console.WriteLine($"{component.GetDescription()} : ${component.GetPrice()}");