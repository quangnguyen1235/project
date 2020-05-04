using NUnit.Framework;
using unitest;
namespace Nunitdemo
{
    public class CalculatorTest
    {
        private Calculator calculator;
        [SetUp]
        public void Setup()
        {
            calculator = new Calculator();
        }

        [Test]
        public void AdditionalTest()
        {
            Assert.AreEqual(10, calculator.additional(3,7));
        }
    }
}