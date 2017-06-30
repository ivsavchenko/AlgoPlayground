using System;
using Algos.Code.Dynamic;
using Algos.Code.Recursion;

namespace Algos.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fibonacci Recursive");
            FibonacciRecursive fib = new FibonacciRecursive();
            var result = fib.CalculateFromNto1(30);

            Console.WriteLine($"Result: {result}");
            Console.WriteLine($"Count of function calls: {fib.OperationCount}");
            
            Console.WriteLine("Fibonacci Dynamic");
            FibonacciDynamic fybDyn = new FibonacciDynamic();
            var resultDyn = fybDyn.Calculate(30);

            Console.WriteLine($"resultDyn: {result}");
            Console.WriteLine($"Count of function calls: {fybDyn.OperationCount}");
        }
    }
}
