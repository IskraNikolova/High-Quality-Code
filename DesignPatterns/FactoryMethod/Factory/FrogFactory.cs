using FactoryMethod.Models;

namespace FactoryMethod.Factory
{
    public class FrogFactory : Factory
    {
        public override Animal AnimalFactory(string gender, int age, string name)
        {
            var frog = new Frog()
            {
                Gender = gender,
                Age = age,
                Name = name
            };

            return frog;
        }
    }
}
