namespace Algos.Code.Arrays
{
    public class MaxRepeatingElement
    {
        public int Calculate(int[] arrA)
        {
            int size = arrA.Length;
            int maxCount = 0;
            int maxIndex = 0;
            for (int i = 0; i < size; i++)
            {
                int index = arrA[i] % size;
                arrA[index] = arrA[index] + size;
            }

            for (int i = 0; i < size; i++)
            {
                if (arrA[i] / size > maxCount)
                {
                    maxCount = arrA[i] / size;
                    maxIndex = i;
                }
            }

            return maxIndex;
            //return arrA[maxIndex] % size;
        }
    }
}
