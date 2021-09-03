using System;
using NUnit.Framework;
using FibonacciNumbersKata;

namespace FibonacciNumbersKata.Tests
{
    /* Sequene of Fibonacci Numbers
     * 1, 1, 2, 3, 5, 8, 13, 21, 34
     * or
     * 0, 1, 1, 2, 3, 5, 8, 13, 21, 34
     */
    [TestFixture]
    public class FibonacciTests
    {
        [TestCase(0, 0)]
        [TestCase(1, 1)]
        [TestCase(2, 1)]
        [TestCase(3, 2)]
        [TestCase(4, 3)]
        [TestCase(5, 5)]
        [TestCase(6, 8)]
        public void TestFibonacci(int index, int expectedResult)
        {
            Assert.AreEqual(expectedResult, Fibonacci.GetFibonacci(index));
        }
    }
}
