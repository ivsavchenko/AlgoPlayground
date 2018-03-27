namespace Algos.Code.Recursion
{
    public class FibonacciTailRecursive
    {
        public int Calculate(int n)
        {
            if (n == 0)
            {
                return 0;
            }

            return Calculate(n, 0, 1);
        }

        public int Calculate(int n, int previous, int current)
        {
            if (n == 1)
            {
                return current;
            }

            return Calculate(n - 1, current, current + previous);
        }
    }
}
