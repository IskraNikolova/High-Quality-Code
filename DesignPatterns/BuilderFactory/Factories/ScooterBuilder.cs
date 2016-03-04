namespace BuilderFactory.Factories
{
    using BuilderFactory.Models;

    public class ScooterBuilder : VehicleBuilder
    {
        public ScooterBuilder()
        {
            this.Vehicle = new Vehicle("Scooter");
        }

        public override void BuildFrame()
        {
            this.Vehicle["frame"] = "scooter frame";
        }

        public override void BuildEngine()
        {
            this.Vehicle["engine"] = "50 cc";
        }

        public override void BuildWheels()
        {
            this.Vehicle["wheels"] = "2";
        }

        public override void BuildDoors()
        {
            this.Vehicle["doors"] = "0";
        }
    }
}