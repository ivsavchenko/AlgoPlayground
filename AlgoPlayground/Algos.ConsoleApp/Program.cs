﻿using System;
using System.Linq;
using System.Numerics;
using Algos.Code.DataStructures.LinkedList;
using Algos.Code.Dynamic;
using Algos.Code.Recursion;
using System.Collections.Generic;
using Algos.Code.Extensions;

namespace Algos.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = new int[2, 5];
            a[1, 4] = 5;
            a.WriteToConsole(0, 2, 0, 5);
            RookProblem problem = new RookProblem(4, 4);
            problem.Solve();
        }
    }

    public class RookProblem
    {
        private int size;
        private int count;
        private int[,] arr;

        private int[,] rooks;
        private Stack<int> stack = new Stack<int>();

        public RookProblem(int size, int count)
        {
            this.size = size;
            this.count = count;
            arr = new int[size, size];
            rooks = new int[size + 1, 2];
            stack.Push(1);
        }

        public void Solve()
        {
            int solutionsFound = 0;
            int rook = 0;
            int startCol = 0;
            int startRow = 0;          
            
            while (rook != 1 || startRow != size - 1)
            {
                rook = stack.Pop();

                if (SetRookIfPossible(rook, startCol, startRow) && rook < count)
                {
                    rook++;
                    stack.Push(rook);
                    startCol = 0;
                    startRow = 0;
                    continue;
                }

                if (stack.Count == 0)
                {
                    arr.WriteToConsole(0, size, 0, size);
                    solutionsFound++;
                }

                bool moveFew;                
                arr[rooks[rook, 0], rooks[rook, 1]] = 0;
                rooks[rook, 0] = 0;
                rooks[rook, 1] = 0;

                do
                {
                    moveFew = false;
                    rook--;
                    stack.Push(rook);
                    int col = rooks[rook, 0];
                    int row = rooks[rook, 1];
                    rooks[rook, 0] = 0;
                    rooks[rook, 1] = 0;

                    arr[col, row] = 0;

                    if (col < size - 1)
                    {
                        startCol = col + 1;
                        startRow = row;
                    }
                    else
                    {
                        if (row < size - 1)
                        {
                            startCol = 0;
                            startRow = row + 1;
                        }
                        else
                        {
                            moveFew = true;
                            stack.Pop();
                        }
                    }
                } while (moveFew);
            }

            Console.WriteLine(solutionsFound);
        }

        private bool SetRookIfPossible(int rook, int startCol, int startRow)
        {
            for (int i = startCol; i < size; i++)
            {
                for (int j = startRow; j < size; j++)
                {
                    if (CheckCell(i, j))
                    {
                        arr[i, j] = rook;
                        rooks[rook, 0] = i;
                        rooks[rook, 1] = j;
                        return true;
                    }
                }
            }

            return false;
        }

        private bool CheckCell(int col, int row)
        {
            for (int k = 0; k < size; k++)
            {
                if(arr[k, row] != 0 || arr[col, k] != 0)                
                {
                    return false;
                }
            }

            return true;
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
