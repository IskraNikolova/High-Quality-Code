namespace FactoryMethod
{
    using FactoryMethod.Factory;

    public class FactoryMethodMainTest
    {
        public static void Main()
        {
            var catFactory = new CatFactory();
            var pisi = catFactory.AnimalFactory("male", 2, "Pisi");
            pisi.ProdiceSound();

            var dogFactory = new DogFactory();
            var sharo = dogFactory.AnimalFactory("male", 5, "Sharo");
            sharo.ProdiceSound();

            var frogFactory = new FrogFactory();
            var frog = frogFactory.AnimalFactory("male", 1, "Frogi");
            frog.ProdiceSound();
        }
    }
}
