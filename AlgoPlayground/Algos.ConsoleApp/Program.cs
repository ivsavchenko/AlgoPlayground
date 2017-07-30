using Algos.Code.Sort;

namespace Algos.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = new int[] { 5, 7, 1, 2, 6, 4 };
            MergeSort sort = new MergeSort();
            int[] output = sort.Sort(input);
        }
    }
}

//int intValue1 = 0b00000000_00000000_00000000_00100011; //35            
//int intValue2 = unchecked((int)0b11111111_11111111_11111111_11011101); //-35
//var arr = Enumerable.Repeat(Enumerable.Repeat(int.MaxValue, n).ToArray(), n).ToArray();