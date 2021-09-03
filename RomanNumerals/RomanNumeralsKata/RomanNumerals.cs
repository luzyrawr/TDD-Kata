using System;
using System.Collections.Generic;

namespace RomanNumeralsKata
{
    public class RomanNumerals
    {
        private static Dictionary<char, int> map = new Dictionary<char, int>()
            {
                { 'I', 1 },
                { 'V', 5 },
                { 'X', 10 },
                { 'L', 50 },
                { 'C', 100 },
                { 'M', 1000 }
            };

        public static int Parser(string romanNumber)
        {
            var result = 0;
            for (int i = 0; i < romanNumber.Length; i++)
            {
                if (i + 1 < romanNumber.Length && IsSubtractive(romanNumber[i], romanNumber[i + 1]))
                    result -= map[romanNumber[i]];
                else
                    result += map[romanNumber[i]];
            }
            return result;
        }

        private static bool IsSubtractive(char c1, char c2)
        {
            return map[c1] < map[c2];
        }
    }
}
