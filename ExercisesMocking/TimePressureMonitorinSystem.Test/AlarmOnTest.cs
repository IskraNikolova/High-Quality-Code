using ConsoleApplication1;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using TDDMicroExercises.TirePressureMonitoringSystem;

namespace TimePressureMonitorinSystem.Test
{
    [TestClass]
    public class AlarmOnTest
     {
        [TestMethod]
        public void CheckIsOutOfRange_IsAlarmOnFalseWhenIsInRange_ShouldBeFalse()
        {
            var mock = new Mock<ISensor>();
            mock.Setup(s => s.PopNextPressurePsiValue()).Returns(18);

            var checkIsTrue = new Alarm(mock.Object);
            checkIsTrue.CheckIsOutOfRange();

            Assert.AreEqual(checkIsTrue.AlarmOn, false);
        }

        [TestMethod]
        public void PopNextPressurePsiValue_IsResultIsCorrect_ShouldBe()
        {
            var mock = new Mock<IRandomProvider>();
            mock.Setup(r => r.GetRandomNumber()).Returns(1);

            var sensor = new Sensor(mock.Object);
            var resultNumber = sensor.PopNextPressurePsiValue();

            Assert.AreEqual(resultNumber, 22);
        }
    }
}
