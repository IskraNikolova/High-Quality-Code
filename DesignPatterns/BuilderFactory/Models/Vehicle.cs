namespace BuilderFactory
{
    using System;
    using System.Collections.Generic;

    public class Vehicle
    {
        private readonly string vehicleType;
        private readonly Dictionary<string, string> parts = 
            new Dictionary<string, string>();

        public Vehicle(string vehicleType)
        {
            this.vehicleType = vehicleType;
        }

        public string this[string key]
        {
            get { return this. parts[key]; }

            set { this.parts[key] = value; }
        }

        public void Show()
        {
            Console.WriteLine("-------------------");
            Console.WriteLine($"Vehicle Type - {this.vehicleType}");
        }
    }
}
