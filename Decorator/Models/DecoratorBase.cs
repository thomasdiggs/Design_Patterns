namespace Decorator.Models
{
    internal abstract class DecoratorBase : IComponent
    {
        protected IComponent _component;

        public DecoratorBase(IComponent component)
        {
            _component = component;
        }

        public virtual string GetDescription()
        {
            return _component.GetDescription();
        }

        public virtual double GetPrice()
        {
            return _component.GetPrice();
        }
    }
}