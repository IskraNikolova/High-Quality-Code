using System;

namespace ConsoleApplication1
{
    public class Sensor : ISensor
    {
        private const double Offset = 16;

        private  IRandomProvider random;

        public Sensor(IRandomProvider random)
        {
            this.random = random;
        }

        public double PopNextPressurePsiValue()
        {
            double randomNumber = this.random.GetRandomNumber();
            double pressureTelemetryValue = (6 * randomNumber * randomNumber) + Offset;

            return pressureTelemetryValue;
        }
    }
}
