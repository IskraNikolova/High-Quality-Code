using System;

namespace FactoryMethod.Models
{
    class Cat : Animal
    {
        public override void ProdiceSound()
        {
            Console.WriteLine("Mqu!");
        }
    }
}
