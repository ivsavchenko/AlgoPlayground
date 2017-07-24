namespace Algos.Code.Numbers
{
    public class EuclideanAlgo
    {
        public int Calculate(int a, int b)
        {
            while(a != b)
            {
                if (a > b)
                {
                    a = a % b;
                    if (a == 0)
                    {
                        return b;
                    }
                }
                else
                {
                    b = b % a;
                    if (b == 0)
                    {
                        return a;
                    }                    
                }
            }

            return a;            
        }
    }
}
