namespace AbstractFactoryMethod
{
    using AbstractFactoryMethod.Factory;
    using AbstractFactoryMethod.Models;

    public class OnlineDeliveryCompany
    {
        private readonly AbstractFactory factory;

        public OnlineDeliveryCompany(AbstractFactory pizzaFactory)
        {
            this.factory = pizzaFactory;
        }

        public CheesePizza DeliveryCheesePizza()
        {
            return factory.MakeCheesePizza();
        }


        public PepperoniPizza DeliveryPepperoniPizza()
        {
            return factory.MakePepperoniPizza();
        }


        public Calzone DeliveryCalzone()
        {
            return factory.MakeCalzonePizza();
        }
    }
}
