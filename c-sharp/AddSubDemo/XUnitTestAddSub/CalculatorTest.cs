using System;
using Xunit;
using AddSubDemo;

namespace XUnitTestAddSub
{
    public class TestCalculator
    {
        private Calculator calculator;
        public TestCalculator()
        {
            calculator = new Calculator();
        }
        [Theory]
        [InlineData(1,2,3)]
        [InlineData(-10, 2, -8)]
        public void AddTest(double a, double b, double expRes)
        {
            var res = calculator.Add(a, b);
            Assert.True(expRes == res);
        }
        [Theory]
        [InlineData(3, 2, 1)]
        [InlineData(-25, -10, -15)]
        public void SubTest(double a, double b, double expRes)
        {
            var res = calculator.Sub(a, b);
            Assert.True(expRes == res);
        }
    }
}