using NUnit.Framework;
using RomanNumeralsKata;
using System;

namespace RomanNumeralsKata.Tests
{
    [TestFixture]
    public class RomanNumeralsTests
    {        
        [TestCase(1,"I")]
        [TestCase(5, "V")]
        [TestCase(10, "X")]
        [TestCase(2, "II")]
        [TestCase(4, "IV")]
        [TestCase(9, "IX")]
        [TestCase(14, "XIV")]

        public void TestParser(int expected, string romanNumber)
        {
            Assert.AreEqual(expected, RomanNumerals.Parser(romanNumber));
        }        
    }    
}