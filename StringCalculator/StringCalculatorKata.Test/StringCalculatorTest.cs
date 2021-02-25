using NUnit.Framework;
using System;

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
        [TestCase("1","1")]
        [TestCase("1,2","3")]
        [TestCase("1,2,3","6")]
        [TestCase("1\n2,3","6")]
        public void AddReturnsSum(string input, string expectedResult)
        {
            var stringCalculator = new StringCalculator();
            var result = stringCalculator.Add(input);
            Assert.AreEqual(expectedResult, result);
        }

        [TestCase("1,-2,-3\n-4","negatives not allowed: -2, -3, -4")]        
        public void AddReturnsError(string input, string expectedMessage)
        {
            var stringCalculator = new StringCalculator();
            var ex = Assert.Throws<Exception>(delegate { stringCalculator.Add(input); });
            Assert.AreEqual(expectedMessage, ex.Message);
        }
    }
}