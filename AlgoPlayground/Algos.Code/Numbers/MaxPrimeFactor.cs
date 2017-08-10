using System;
using System.Collections.Generic;
using System.Linq;

namespace Algos.Code.Numbers
{
    public class MaxPrimeFactor
    {
        public long CalculateBrute(long n)
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


        public long Calculate(long n)
        {
            List<long> factors = new List<long>();            
            while (n % 2 == 0)
            {
                factors.Add(2);
                n /= 2;
            }            

            long d = 3;
            double sqrt = Math.Sqrt(n);
            while (n > 1)
            {
                while (n % d == 0)
                {
                    if(d >= sqrt)
                    {
                        return d;
                    }

                    factors.Add(d);
                    n /= d;
                }
                d += 2;
            }

            return factors.Max();
        }
    }
}
