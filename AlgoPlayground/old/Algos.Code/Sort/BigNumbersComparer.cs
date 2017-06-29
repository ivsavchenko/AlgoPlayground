using System.Collections.Generic;

namespace Algos.Code.Sort
{
    /// <summary>
    /// Use it in case you want to compare really big numbers which stores as string 
    /// </summary>
    public class BigNumbersComparer : IComparer<string>
    {
        public static BigNumbersComparer GetInstance => new BigNumbersComparer();

        public int Compare(string x, string y)
        {
            int xLength = x?.Length ?? 0;
            int yLength = y?.Length ?? 0;

            if (xLength != yLength)
            {
                return xLength.CompareTo(yLength);
            }

            int result = 0;
            for (int i = 0; i < xLength; i++)
            {
                if (x[i] == y[i])
                {
                    continue;
                }

                if (x[i] >= y[i])
                {
                    result = 1;
                    break;
                }

                result = -1;
                break;
            }

            return result;
        }
    }
}
