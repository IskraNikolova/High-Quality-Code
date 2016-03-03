namespace AbstractFactoryMethod.Factory
{
    using AbstractFactoryMethod.Models;

    public abstract class AbstractFactory
    {
        public abstract CheesePizza MakeCheesePizza();

        public abstract PepperoniPizza MakePepperoniPizza();

        public abstract Calzone MakeCalzonePizza();
    }
}
