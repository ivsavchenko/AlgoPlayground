﻿using System;
using System.Linq;
using System.Numerics;
using Algos.Code.DataStructures.LinkedList;
using Algos.Code.Dynamic;
using Algos.Code.Recursion;
using System.Collections.Generic;
using Algos.Code.Backtracking;
using Algos.Code.Extensions;

namespace Algos.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {           
        }
    }    
}

    //int intValue1 = 0b00000000_00000000_00000000_00100011; //35            
    //int intValue2 = unchecked((int)0b11111111_11111111_11111111_11011101); //-35

    //var arr = Enumerable.Repeat(Enumerable.Repeat(int.MaxValue, n).ToArray(), n).ToArray();

    /*
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
    */
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
