using NUnit.Framework;
using System;

namespace CalcStatsKata.Tests
{
    /*
     * Your task is to process a sequence of integer numbers to determine the following statistics:

        minimum value
        maximum value
        number of elements in the sequence
        average value
        For example: [6, 9, 15, -2, 92, 11]

        minimum value = -2
        maximum value = 92
        number of elements in the sequence = 6
        average value = 21.833333
     */
    public class CalcStatsTests
    {        

        [Test]
        public void GetMin_NoArguments_ThrowsException()
        {
            Assert.Throws<ArgumentNullException>(() =>
            {
                var calcStats = new CalcStats(null);
            });
        }
        
        [Test]
        public void GetMin_OneNumber_ReturnsNumber()
        {
            var calcStats = new CalcStats(-1);
            Assert.AreEqual(-1, calcStats.Min);
        }

        [Test]
        public void GetMin_Numbers_ReturnsMin()
        {
            var calcStats = new CalcStats(-1, 0, 4, -4, 10);
            Assert.AreEqual(-4, calcStats.Min);
        }

        [Test]
        public void GetMax_NoArguments_ThrowsException()
        {
            Assert.Throws<ArgumentNullException>(() =>
            {
                var calcStats = new CalcStats(null);
            });
        }

        [Test]
        public void GetMax_Numbers_ReturnsMax()
        {
            var calcStats = new CalcStats(4, 5, 1, 0, 23);
            Assert.AreEqual(23, calcStats.Max);
        }

        [Test]
        public void GetCount_Numbers_ReturnsCount()
        {
            var calcStats = new CalcStats(4, 5, 1, 0, 23);
            Assert.AreEqual(5, calcStats.Count);
        }

        [Test]
        public void GetAvg_Numbers_ReturnsAvg()
        {
            var calcStats = new CalcStats(10, 9, 8, 6, 10);
            Assert.AreEqual(8.6, calcStats.Avg);
        }
    }
}