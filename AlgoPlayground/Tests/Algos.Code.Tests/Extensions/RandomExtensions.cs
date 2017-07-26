using System;
using System.Collections.Generic;

namespace Algos.Code.Tests.Extensions
{
    public static class RandomExtensions
    {
        public static IEnumerable<int> GenerateIntArray(this Random r, int size)
        {
            for (int i = 0; i < size; i++)
            {
                yield return r.Next();
            }
        }
    }
}
