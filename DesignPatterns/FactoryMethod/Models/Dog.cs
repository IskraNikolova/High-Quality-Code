using System;

namespace FactoryMethod.Models
{
    public class Dog : Animal
    {
        public override void ProdiceSound()
        {
            Console.WriteLine("Bay!");
        }
    }
}
