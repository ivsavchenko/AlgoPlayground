namespace Algos.Code.Recursion
{
    public class FibonacciRecursive
    {
        public long OperationCount { get; private set; }

        public int CalculateFromNto1(int n)
        {
            OperationCount++;
            if (n == 1 || n == 2)
            {                
                return 1;
            }

            return CalculateFromNto1(n - 1) + CalculateFromNto1(n - 2);
        }
    }
}