using System;

class Program
{
    static void Main()
    {
        int result = ReyRom.Recursion.Fibonacci(40);
        Console.WriteLine($"Fibonacci(40) = {result}");

        result = MoIce.Recursion.Factorial(6);
        Console.WriteLine($"Factorial(6) = {result}");
    }
}
