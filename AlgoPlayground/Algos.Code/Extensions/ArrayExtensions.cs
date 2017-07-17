using System;

namespace Algos.Code.Extensions
{
    public static class ArrayExtensions
    {
        public static void WriteToConsole(this int[,] arr, int startingColumn, int n, int startingRow, int m, bool separate = true)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {                    
                    Console.Write($"{arr[i, j]} ");
                }
                Console.WriteLine();
            }

            if (separate)
            {
                Console.WriteLine("***");
            }
        }
    }
}
