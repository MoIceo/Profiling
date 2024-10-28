﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReyRom
{
    public static class Recursion
    {
        public static int Fibonacci(int n)
        {
            if (n <= 1) return n;
            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }
    }
}

namespace MoIce
{
    public static class Recursion
    {
        public static int Factorial(int n)
        {
            if (n < 0) return -1;
            if (n == 0) return 1;
            return n * Factorial(n - 1);
        }
    }
}