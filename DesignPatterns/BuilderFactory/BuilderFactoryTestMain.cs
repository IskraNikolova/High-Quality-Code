using BuilderFactory.Factories;

namespace BuilderFactory
{
    public class BuilderFactoryTestMain
    {
        public static void Main()
        {
            var shop = new Shop();

            var carBuilder = new CarBuilder();
            shop.Construct(carBuilder);
            carBuilder.Vehicle.Show();

            var scooterBuilder = new ScooterBuilder();
            shop.Construct(scooterBuilder);
            scooterBuilder.Vehicle.Show();
        }
    }
}
