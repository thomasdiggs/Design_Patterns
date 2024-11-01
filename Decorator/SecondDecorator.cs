namespace Decorator
{
    internal class SecondDecorator : DecoratorBase
    {
        public SecondDecorator(IComponent component) : base(component)
        {
        }

        public override string GetDescription()
        {
            return _component.GetDescription() + ", with second decorator";
        }

        public override double GetPrice()
        {
            return _component.GetPrice() + 20.0;
        }
    }
}