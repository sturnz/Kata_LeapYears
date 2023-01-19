using Kata_LeapYears;

namespace Kata_LeapYears_Tests
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        [DataRow (2000)]
        [DataRow (1912)]
        [DataRow (24)]
        [DataRow (1432)]
        [DataRow (392)]
        public void Are_Leap_Years_Should_Return_True(int year)
        {

            bool actual = year.CheckForLeapYears();

            Assert.IsTrue(actual);
        }


        [TestMethod]
        [DataRow(371)]
        [DataRow(2247)]
        [DataRow(9)]
        [DataRow(1917)]
        [DataRow(1337)]
        [DataRow(0)]
        public void Are_Not_Leap_Years_Should_Return_False(int year)
        {

            bool actual = year.CheckForLeapYears();

            Assert.IsFalse(actual);
        }

        [TestMethod]
        [DataRow(-4)]
        [DataRow(-3)]
        public void Negative_Years_Throw_Exception(int year)
        {
            Assert.ThrowsException<ArgumentOutOfRangeException>(() =>
                year.CheckForLeapYears());
        }
    }
}