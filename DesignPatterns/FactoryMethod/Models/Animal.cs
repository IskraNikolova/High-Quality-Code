namespace FactoryMethod.Models
{
    public abstract class Animal
    {
        public string Gender { get; set; }

        public int Age { get; set; }

        public string Name { get; set; }

        public abstract void ProdiceSound();
    }
}
