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

        public int Min => _numbers.Min();
        public int Max => _numbers.Max();
        public double Count => _numbers.Count();
        public double Avg =>  _numbers.Average();        
    }
}