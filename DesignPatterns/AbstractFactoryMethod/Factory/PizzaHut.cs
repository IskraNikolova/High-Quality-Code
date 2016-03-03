namespace AbstractFactoryMethod.Factory
{
    using System.Collections.Generic;
    using AbstractFactoryMethod.Models;

    public class PizzaHut : AbstractFactory
    {
        private const string name = "Pizza Hut";

        public string Name
        {
            get { return name; }
        }

        public override CheesePizza MakeCheesePizza()
        {
            var ingridients = new List<string>()
            {
                "butter",
                "tomatoes",
                "cheese",
            };

            var pizza = new CheesePizza(ingridients, this.Name);

            return pizza;
        }

        public override PepperoniPizza MakePepperoniPizza()
        {
            var ingridients = new List<string>()
            {
                "green tomatoes",
                "blue cheese",
            };

            var pizza = new PepperoniPizza(ingridients, this.Name);

            return pizza;
        }

        public override Calzone MakeCalzonePizza()
        {
            var ingridients = new List<string>()
            {
                "butter",
                "white tomatoes",
                "red cheese",
            };

            var pizza = new Calzone(ingridients, this.Name);

            return pizza;
        }
    }
}
