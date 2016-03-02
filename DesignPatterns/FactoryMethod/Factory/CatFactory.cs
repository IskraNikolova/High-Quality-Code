using FactoryMethod.Models;

namespace FactoryMethod.Factory
{
    public class CatFactory : Factory
    {
        public override Animal AnimalFactory(string gender, int age, string name)
        {
            var cat = new Cat()
            {
                Gender = gender,
                Age = age,
                Name = name
            };

            return cat;
        }
    }
}
