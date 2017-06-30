namespace Algos.Code.Dynamic
{
    public class FibonacciDynamic
    {
        public long OperationCount { get; private set; }

        public int Calculate(int n)
        {
            int[] values = new int[n + 1];
            
            values[1] = 1;
            values[2] = 1;
            OperationCount = 2;
            
            for (int i = 3; i <= n; i++)
            {
                OperationCount++;
                values[i] = values[i - 1] + values[i - 2];
            }

            return values[n];
        }
    }
}