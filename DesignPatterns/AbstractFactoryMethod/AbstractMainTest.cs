using System;
using AbstractFactoryMethod.Factory;

namespace AbstractFactoryMethod
{
    public class AbstractMainTest
    {
        public static void Main()
        {
            var pizzaPlace = new IskraPizza();
            var deliveryPizza = new OnlineDeliveryCompany(pizzaPlace);

            var calzone = deliveryPizza.DeliveryCheesePizza();

            Console.WriteLine(calzone.Name);
            Console.WriteLine($"Ingridients {string.Join(", ", calzone.Ingridients)}");
        }
    }
}
