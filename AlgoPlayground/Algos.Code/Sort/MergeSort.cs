using System.Linq;

namespace Algos.Code.Sort
{
    public class MergeSort
    {
        public int Counter { get; set; } = 0;

        public int[] Sort(int[] arr)
        {
            if(arr.Length == 1)
            {
                return arr;
            }

            return Split(arr);
		}

        private int[] Split(int[] arr)
        {
            int seam = arr.Length / 2;

            int[] left = arr.Take(seam).ToArray();
            int[] right = arr.Skip(seam).ToArray(); 

            var sortedLeft = Sort(left);
            var sortedRight = Sort(right);

            return Merge(sortedLeft, sortedRight);
        }

        private int[] Merge(int[] left, int[] right)
        {
            int[] result = new int[left.Length + right.Length];
            int indR = 0;
            int indL = 0;

            for (int i = 0; i < left.Length + right.Length; i++)
            {
                if ((indL < left.Length && indR == right.Length) ||
                    (indL < left.Length && indR < right.Length && left[indL] < right[indR]))
                {
                    result[i] = left[indL];
                    indL++;

                    Counter++;
                }
                else 
                if ((indR < right.Length && indL == left.Length) ||
                    (indL < left.Length && indR < right.Length && right[indR] < left[indL]))
                {
                    result[i] = right[indR];
                    indR++;

                    Counter++;
                }
            }

            return result;
        }
    }
}
