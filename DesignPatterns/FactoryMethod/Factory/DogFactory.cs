using FactoryMethod.Models;

namespace FactoryMethod.Factory
{
    public class DogFactory : Factory
    {
        public override Animal AnimalFactory(string gender, int age, string name)
        {
            var dog = new Dog()
            {
                Gender = gender,
                Age = age,
                Name = name
            };

            return dog;
        }
    }
}
