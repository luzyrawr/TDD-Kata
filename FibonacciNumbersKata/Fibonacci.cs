using System;
using System.Collections.Generic;
using System.Text;

namespace FibonacciNumbersKata
{
    public class Fibonacci
    {
        public static int GetFibonacci(int index)
        {
            if (index == 0) return 0;
            if (index == 1) return 1;
            return GetFibonacci(index - 2) + GetFibonacci(index - 1);
        }
    }
}
