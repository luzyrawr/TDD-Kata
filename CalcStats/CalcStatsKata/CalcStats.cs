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

        public int GetMin => _numbers.Min();
        public int GetMax => _numbers.Max();
        public double GetCount => _numbers.Count();
        public double GetAvg =>  _numbers.Average();
        
    }
}