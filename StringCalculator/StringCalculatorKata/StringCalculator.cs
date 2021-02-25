using System;

namespace StringCalculatorKata
{
    public class StringCalculator
    {
        public string Add(string numbers)
        {
            var arrNumbers = numbers.Split(",");

            if (arrNumbers[0] == "")
                return "0";

            return string.Empty;
        }
    }
}
