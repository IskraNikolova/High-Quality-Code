namespace BuilderFactory.Factories
{
    using BuilderFactory.Models;

    public class CarBuilder : VehicleBuilder
    {
        public CarBuilder()
        {
            this.Vehicle = new Vehicle("Car");
        }

        public override void BuildFrame()
        {
            this.Vehicle["frame"] = "Car frame";
        }

        public override void BuildEngine()
        {
            this.Vehicle["engine"] = "2500 cc";
        }

        public override void BuildWheels()
        {
            this.Vehicle["whees"] = "4";
        }

        public override void BuildDoors()
        {
            this.Vehicle["doors"] = "4";
        }
    }
}