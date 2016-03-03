namespace AbstractFactoryMethod.Factory
{
    using System.Collections.Generic;
    using AbstractFactoryMethod.Models;

    public class IskraPizza : AbstractFactory
    {
        private const string name = "Iskra pizza";

        public string Name
        {
            get
            {
                return name;
            }
        }

        public override CheesePizza MakeCheesePizza()
        {
            var ingridients = new List<string>()
            {
                "tomatoes",
                "cheese",
                "butter"
            };

            var pizza = new CheesePizza(ingridients, this.Name);

            return pizza;
        }

        public override PepperoniPizza MakePepperoniPizza()
        {
            var ingridients = new List<string>()
            {
                "tomatoes",
                "cheese",
                "butter"
            };

            var pizza = new PepperoniPizza(ingridients, this.Name);

            return pizza;
        }

        public override Calzone MakeCalzonePizza()
        {
            var ingridients = new List<string>()
            {
                "tomatoes",
                "cheese",
                "butter"
            };

            var pizza = new Calzone(ingridients, this.Name);

            return pizza;
        }
    }
}
