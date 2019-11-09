using NUnit.Framework;
using TestsAndPatterns;
namespace Tests
{
    public class Tests
    {
        [TestCase(2,2,4)]
        [TestCase(2,-2,0)]
        [TestCase(-2,2,0)]
        public void Add_TwoNumbers(double firstNumber, double secondNuber, double expectedResult)
        {
            var calculator = new Calculator();
            var result = calculator.Addition(firstNumber, secondNuber);
            Assert.AreEqual(expectedResult, result);
        }

        [TestCase(2, 2, 4)]
        [TestCase(2, -2, -4)]
        [TestCase(-2, 2, -4)]
        [TestCase(2, 0, 0)]
        public void Multiply_TwoNumbers(double firstNumber, double secondNuber, double expectedResult)
        {
            var calculator = new Calculator();
            var result = calculator.Multiplication(firstNumber, secondNuber);
            Assert.AreEqual(expectedResult, result);
        }
    }
}