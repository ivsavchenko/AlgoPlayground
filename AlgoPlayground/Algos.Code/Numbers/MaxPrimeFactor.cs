using System.Collections.Generic;
using System.Linq;

namespace Algos.Code.Numbers
{
    public class MaxPrimeFactor
    {
        public long Calculate(long n)
        {
            List<long> factors = new List<long>();
            long d = 2;

            while (n > 1)
            {
                while (n % d == 0)
                {
                    factors.Add(d);
                    n /= d;
                }
                d++;
            }

            return factors.Max();
        }
    }
}
