using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace DateTime.Now.AddDays.Test
{
    [TestClass]
    public class AddDaysMethodsTest
    {
        [TestMethod]
        public void DateTime_AddOneDayInMiddleOfMonth_ShouldAdded()
        {
            var mock = new Mock<IDateTimeProvider>();
            mock.Setup(d => d.DateTimeNow).Returns(new System.DateTime(2016, 07, 16));

            var date = mock.Object.DateTimeNow.AddDays(1);
            var expected = new System.DateTime(2016, 7, 17);

            Assert.AreEqual(date, expected);
        }

        [TestMethod]
        public void DateTime_AddOneDayInTheEndOfTheMonth_ShouldReturnDayOfNextMonth()
        {
            var mock = new Mock<IDateTimeProvider>();
            mock.Setup(d => d.DateTimeNow).Returns(new System.DateTime(2016, 7, 31));

            var date = mock.Object.DateTimeNow.AddDays(1);
            var expected = new System.DateTime(2016, 8, 01);

            Assert.AreEqual(date, expected);
        }

        [TestMethod]
        public void DateTime_AddNagativeCountOfDays_ShouldReturnDayOfFrontMonth()
        {
            var mock = new Mock<IDateTimeProvider>();
            mock.Setup(d => d.DateTimeNow).Returns(new System.DateTime(2016, 7, 5));

            var date = mock.Object.DateTimeNow.AddDays(-5);
            var expected = new System.DateTime(2016, 6, 30);

            Assert.AreEqual(date, expected);
        }

        [TestMethod]
        public void DateTime_AddingADayToALeapYear_ShouldReturnNextDayOfFebruary()
        {
            var mock = new Mock<IDateTimeProvider>();
            mock.Setup(d => d.DateTimeNow).Returns(new System.DateTime(2008, 02, 28));

            var date = mock.Object.DateTimeNow.AddDays(1);
            var expected = new System.DateTime(2008, 02, 29);

            Assert.AreEqual(date, expected);
        }

        [TestMethod]
        public void DateTime_AddingADayToANotLeapYear_ShouldReturnDayOfMart()
        {
            var mock = new Mock<IDateTimeProvider>();
            mock.Setup(d => d.DateTimeNow).Returns(new System.DateTime(1900, 02, 28));

            var date = mock.Object.DateTimeNow.AddDays(1);
            var expected = new System.DateTime(1900, 03, 01);

            Assert.AreEqual(date, expected);
        }
    }
}
  

