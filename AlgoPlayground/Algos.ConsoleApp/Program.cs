﻿using System;
using Algos.Code.DataStructures.LinkedList;
using Algos.Code.Dynamic;
using Algos.Code.Recursion;

namespace Algos.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> ll = new LinkedList<int>();
            ll.Add(1);
            ll.Add(2);
            ll.Add(3);

            ll.Delete(0);
            ll.Delete(0);
			ll.Delete(0);

            ll.Insert(0, 10);
            ll.Insert(0, 11);
            ll.Insert(0, 12);
            ll.Add(77);
            ll.Insert(2, 555);

			foreach (var item in ll)
			{
				Console.WriteLine(item.Value);
			}

        /*    Console.WriteLine("Fibonacci Recursive");
            FibonacciRecursive fib = new FibonacciRecursive();
            var result = fib.CalculateFromNto1(30);

            Console.WriteLine($"Result: {result}");
            Console.WriteLine($"Count of function calls: {fib.OperationCount}");
            
            Console.WriteLine("Fibonacci Dynamic");
            FibonacciDynamic fybDyn = new FibonacciDynamic();
            var resultDyn = fybDyn.Calculate(30);

            Console.WriteLine($"resultDyn: {result}");
            Console.WriteLine($"Count of function calls: {fybDyn.OperationCount}");*/
        }
    }
}
