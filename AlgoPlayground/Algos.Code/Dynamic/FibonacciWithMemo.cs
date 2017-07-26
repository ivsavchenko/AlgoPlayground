namespace Algos.Code.Dynamic
{
    public class FibonacciWithMemo
    {
        private int[] fibonacciNumbers;

        public int Calculate(int n)
        {
            fibonacciNumbers = new int[n + 1];
            fibonacciNumbers[0] = 0;
            fibonacciNumbers[1] = 1;

            return CalculateWithMemo(n);
        }

        private int CalculateWithMemo(int n)
        {
            if (n == 1 || n == 2)
            {
                return 1;
            }

            if (fibonacciNumbers[n - 1] == 0)
            {
                fibonacciNumbers[n - 1] = CalculateWithMemo(n - 1);
            }

            if (fibonacciNumbers[n - 2] == 0)
            {
                fibonacciNumbers[n - 2] = CalculateWithMemo(n - 2);
            }

            fibonacciNumbers[n] = fibonacciNumbers[n - 1] + fibonacciNumbers[n - 2];

            return fibonacciNumbers[n];
        }
    }
}