namespace AbstractFactoryMethod.Models
{
    using System.Collections.Generic;

    public abstract class Pizza
    {
        protected Pizza(IEnumerable<string> ingridients)
        {
            this.Ingridients = new List<string>(ingridients);
        }

        public IEnumerable<string> Ingridients { get; }

        public abstract string Name { get; }
    }
}
