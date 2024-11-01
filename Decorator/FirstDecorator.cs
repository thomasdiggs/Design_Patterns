namespace Decorator
{
    internal class FirstDecorator : DecoratorBase
    {
        public FirstDecorator(IComponent component) : base(component)
        {
        }

        public override string GetDescription()
        {
            return _component.GetDescription() + ", with first decorator";
        }

        public override double GetPrice()
        {
            return _component.GetPrice() + 10.0;
        }
    }
}