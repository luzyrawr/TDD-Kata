using System;

namespace StringCalculatorKata
{
    public class StringCalculator
    {
        public string Add(string numbers)
        {
            var arrNumbers = numbers.Split(",");

            return arrNumbers[0] == "" ? "0" : string.Empty;
        }
    }
}
