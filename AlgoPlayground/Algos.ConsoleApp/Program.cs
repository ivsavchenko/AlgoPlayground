﻿using System;
using System.Linq;
using System.Numerics;
using Algos.Code.DataStructures.LinkedList;
using Algos.Code.Dynamic;
using Algos.Code.Recursion;

namespace Algos.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputStr = Console.ReadLine().Split(' ');
            int[] arr = inputStr.Select(x => int.Parse(x)).ToArray();
			int size = arr[2];

			BigInteger[] result = new BigInteger[size];
			result[0] = arr[0];
			result[1] = arr[1];

			for (int i = 2; i < size; i++)
			{
				//Can't use Math.Pow here, because it doesn't accept BigInteger as a parameter
				result[i] = result[i - 2] + result[i - 2] * result[i - 2];
			}

            /*
			Console.WriteLine(result[size - 1]);
            BigInteger b;
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
			}*/

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
