using konsolprojekt;
namespace lommeregner_test
{
    public class CalculatorTests
    {
        private readonly ICalculator calculator;

        public CalculatorTests()
        {
            calculator = new Calculator();
        }

        [Fact]
        public void Add_ReturnsCorrectSum()
        {
            int result = calculator.Add(5, 3);
            Assert.Equal(8, result);
        }

        [Fact]
        public void Subtract_ReturnsCorrectDifference()
        {
            int result = calculator.Subtract(10, 4);
            Assert.Equal(6, result);
        }

        [Fact]
        public void Multiply_ReturnsCorrectProduct()
        {
            int result = calculator.Multiply(6, 7);
            Assert.Equal(42, result);
        }

        [Fact]
        public void Divide_ReturnsCorrectQuotient()
        {
            double result = calculator.Divide(10, 2);
            Assert.Equal(5.0, result);
        }

        [Fact]
        public void Divide_ByZero_ThrowsException()
        {
            Assert.Throws<DivideByZeroException>(() => calculator.Divide(10, 0));
        }
        [Fact]
        public void Power_ReturnsCorrectResult()
        {
            double result = calculator.Power(2, 3);
            Assert.Equal(8.0, result);
        }
        [Fact]
        public void Power_NegativeBase_ReturnsCorrectResult()
        {
            double result = calculator.Power(-2, 3);
            Assert.Equal(-8.0, result);
        }

        [Fact]
        public void SquareRoot_ReturnsCorrectResult()
        {
            double result = calculator.SquareRoot(16);
            Assert.Equal(4.0, result);
        }
        [Fact]
        public void SquareRoot_NegativeNumber_ThrowsException()
        {
            Assert.Throws<ArgumentException>(() => calculator.SquareRoot(-4));
        }

    }
}