namespace Algos.Code.Sort
{
    public class ShellSort
    {
        private readonly int[] ciuraNumbers = new[] { 1, 4, 10, 23, 57, 132, 301, 701, 1750 };

        public int Counter { get; set; } = 0;

        public int[] Sort(int[] a)
        {
            for(int i = ciuraNumbers.Length - 1; i >= 0; i--)
            {                
                a = Sort(a, ciuraNumbers[i]);
            }

            return a;
        }

        public int[] Sort(int[] a, int step)
        {            
            for(int i = step; i < a.Length; i++)
            {
                int cur = a[i];
                int index = i;

                for(int j = i - step; j >= 0; j -= step)
                {
                    if (a[j] > cur)
                    {
                        Counter++;

                        a[index] = a[j];
                        index -= step;
                    }
                    else
                    {
                        break;
                    }
                }

                if(index != i)
                {
                    Counter++;
                    a[index] = cur;
                }
            }

            return a;
        }
    }
}
