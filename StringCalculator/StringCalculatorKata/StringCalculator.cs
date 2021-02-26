using System;
using System.Linq;
using System.Text;

namespace StringCalculatorKata
{
    public class StringCalculator
    {
        public string Add(string numbers)
        {
            var arrNumbers = numbers.Split(new[] { ",", "\n" }, StringSplitOptions.None);

            var hasNegativesMessage = hasNegatives(arrNumbers);
            if (!string.IsNullOrEmpty(hasNegativesMessage))
                throw new Exception($"negatives not allowed: {hasNegativesMessage}");

            return arrNumbers.Length==1 && arrNumbers[0].Equals("") ? "0" : arrNumbers.Sum(x => int.Parse(x)).ToString();
        }

        public string hasNegatives(string[] numbers)
        {
            StringBuilder sb = new StringBuilder();

            foreach(var number in numbers)
            {
                if (number.Contains('-'))                
                    sb.Append($"{number},");
            }

            if(sb.Length > 0)
                sb.Remove(sb.Length - 1, 1);

            return sb.ToString();
        }
    }
}
