using ConsoleApplication1;

namespace TDDMicroExercises.TirePressureMonitoringSystem
{
    public class Alarm
    {
        private const double LowPressureThreshold = 17;
        private const double HighPressureThreshold = 21;

        private readonly ISensor sensor;

        public Alarm(ISensor sensor)
        {
            this.sensor = sensor;
            this.AlarmOn = AlarmOn;
        }

        public bool AlarmOn { get; set; }

        public void CheckIsOutOfRange()
        {
            double psiPressureValue = this.sensor.PopNextPressurePsiValue();

            if (psiPressureValue < LowPressureThreshold || HighPressureThreshold < psiPressureValue)
            {
                AlarmOn = true;
            }
        }
    }
}
