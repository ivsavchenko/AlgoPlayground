using System;
using Algos.Code.Recursion;

namespace Algos.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            FibonacciRecursive fib = new FibonacciRecursive();
            var result = fib.CalculateFromNto1(6);

            Console.WriteLine($"Result: {result}");
            Console.WriteLine($"Count of function calls: {fib.OperationCount}");
            Console.WriteLine($"{Math.Pow(2, 6)}");
        }
    }
}
