using System;
using System.Linq;

namespace CalcStatsKata
{
    public class CalcStats
    {
        private static int[] _numbers { get; set; }

        public CalcStats(params int[] numbers)
        {
            if (numbers == null)
                throw new ArgumentNullException();

            _numbers = numbers;
        }

        public int GetMin()
        {   
            return _numbers.Min();
        }

        public int GetMax()
        {
            return _numbers.Max();
        }

        public double GetCount()
        {
            return _numbers.Count();
        }

        public double GetAvg()
        {
            return _numbers.Average();
        }
    }
}