using System;
using System.Collections.Generic;
using System.Linq;

namespace Algos.Code.Tests.Extensions
{
    public static class EnumerableExtensions
    {
        public static bool IsSorted<T>(this IEnumerable<T> input) where T: IComparable
        {
            var actual = input.ToArray();
            var sorted = actual.OrderBy(x => x).ToArray();

            for (int i = 0; i < actual.Length; i++)
            {
                if (actual[i].CompareTo(sorted[i]) != 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
