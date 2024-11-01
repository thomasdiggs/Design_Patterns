namespace Decorator
{
    internal class BasicComponent : IComponent
    {
        public BasicComponent()
        {
        }

        public string GetDescription()
        {
            return "A basic component";
        }

        public double GetPrice()
        {
            return 100.0;
        }
    }
}