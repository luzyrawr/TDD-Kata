using NUnit.Framework;

namespace StringCalculatorKata.Test
{
    public class StringCalculatorTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [TestCase("","0")]
        public void AddReturnsSum(string input, string expectedResult)
        {
            var stringCalculator = new StringCalculator();
            var result = stringCalculator.Add(input);
            Assert.AreEqual(expectedResult, result);
        }
    }
}