using FactoryMethod.Models;

namespace FactoryMethod.Factory
{
    public abstract class Factory
    {
        public abstract Animal AnimalFactory(string gender, int age, string name);
    }
}
