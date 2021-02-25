using System;
using System.Linq;

namespace StringCalculatorKata
{
    public class StringCalculator
    {
        public string Add(string numbers)
        {
            var arrNumbers = numbers.Split(",");           

            return arrNumbers.Length==1 && arrNumbers[0].Equals("") ? "0" : arrNumbers.Sum(x => int.Parse(x)).ToString();
        }
    }
}
