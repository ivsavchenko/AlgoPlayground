namespace Algos.Code.Sort
{
    public class InsertionSort
    {
        public int Counter { get; set; } = 0;

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
                    Counter++;

                    arr[index] = arr[index - 1];
                    index--;
                }

                if (index != i)
                {
                    Counter++;

                    arr[index] = currentValue;
                }
            }

            return arr;
        }

        /// <summary>
        /// just another implementation without while loop
        /// </summary>        
        public int[] SortWithoutWhile(int[] arr)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                int cur = arr[i];
                int index = i;

                for (int j = i - 1; j >= 0; j--)
                {
                    if (arr[j] > cur)
                    {
                        arr[index] = arr[j];
                        index--;
                    }
                    else
                    {
                        break;
                    }
                }

                if (index != i)
                {
                    arr[index] = cur;
                }
            }

            return arr;
        }

    }
}
