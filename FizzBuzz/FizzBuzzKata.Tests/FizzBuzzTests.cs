using NUnit.Framework;
using System;
using FizzBuzzKata;

namespace FizzBuzzKata.Tests
{
    [TestFixture]
    public class FizzBuzzTests
    {   
        [TestCase("Fizz", 3)]
        [TestCase("Buzz", 5)]
        [TestCase("Fizz", 6)]
        [TestCase("", 7)]
        [TestCase("Buzz", 10)]
        [TestCase("FizzBuzz", 15)]
        [TestCase("FizzBuzz", 30)]
        public void TestFizzBuzz(string expected, int number)
        {
            Assert.AreEqual(expected, FizzBuzz.FizzBuzzer(number));
        }        
    }
}