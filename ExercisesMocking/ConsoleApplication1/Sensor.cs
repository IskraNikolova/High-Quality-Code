using System;

namespace ConsoleApplication1
{
    public class Sensor : ISensor
    {
        private const double Offset = 16;

        private readonly Random random = new Random();

        public double PopNextPressurePsiValue()
        {
            double pressureTelemetryValue = (6 * random.NextDouble() * random.NextDouble()) + Offset;

            return pressureTelemetryValue;
        }
    }
}
