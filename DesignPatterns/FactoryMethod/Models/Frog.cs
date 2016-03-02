namespace FactoryMethod.Models
{
    using System;

    class Frog : Animal
    {
        public override void ProdiceSound()
        {
            Console.WriteLine("Kvak!");
        }
    }
}
