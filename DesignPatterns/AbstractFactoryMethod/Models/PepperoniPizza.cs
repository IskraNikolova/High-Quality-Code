namespace AbstractFactoryMethod.Models
{
    using System.Collections.Generic;

    public class PepperoniPizza : Pizza
    {
        private readonly string madeBy;

        public PepperoniPizza(IEnumerable<string> ingridients, string madeBy) 
            : base(ingridients)
        {
            this.madeBy = madeBy;
        }

        public override string Name
        {
            get { return string.Format($"Made by {this.madeBy}"); }
        }
    }
}
