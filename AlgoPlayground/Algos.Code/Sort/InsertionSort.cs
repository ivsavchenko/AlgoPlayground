namespace Algos.Code.Sort
{
    public class InsertionSort
    {
        public int[] Sort(int[] arr)
        {
            int length = arr.Length;

            if (length == 0 || length == 1)
            {
                return arr;
            }

            for (int i = 1; i < arr.Length; i++)
            {                
                int currentValue = arr[i];
                int index = i;

                while (index > 0 && currentValue < arr[index - 1])
                {
                    arr[index] = arr[index - 1];
                    index--;
                }

                if (index != i)
                {
                    arr[index] = currentValue;
                }
            }

            return arr;
        }
    }
}
