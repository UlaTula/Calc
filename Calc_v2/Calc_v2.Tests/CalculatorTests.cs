using Xunit;

namespace Calc_v2.Tests
{
    public class CalculatorTests
    {
        [Theory]
        [InlineData(4, 3, 7)]
        [InlineData(10.5, 10.5, 21)]
        public void GetTwoNumbers_WhenAddNumbers_ThenReturnResult(double a, double b, double expected)
        {
            double actual = Calculator.Add(a, b);

            Assert.Equal(expected, actual);
        }

        [Fact]

        public void GetTwoNumbers_WhenDivNumbers_ThenReturnResult()
        {
            double a = 12;
            double b = 4;
            double expected = 3;


            Assert.Equal(expected, Calculator.Div(a, b));
        }
    }
}