using System.Linq;

namespace Algos.Code.Arrays
{
    /// <summary>
    /// Calculate the sum of array elements using divide and conquer paradigm 
    /// </summary>
    public class SumDivAndConq
    {
        public int Calculate(int[] arr)
        {
            if(arr == null || arr.Length == 0) //just a defensive part, no need for it in algo if user passes any array
            {
                return 0;
            }

            if (arr.Length == 1)
            {
                return arr[0];
            }

            int seamIndex = arr.Length / 2;
            
            var left = arr.Take(seamIndex).ToArray();
            var right = arr.Skip(seamIndex).ToArray();

            return Calculate(left) + Calculate(right);
        }
    }
}
