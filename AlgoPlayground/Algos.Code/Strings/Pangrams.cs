using System;
using System.Collections.Generic;

namespace Algos.Code.Strings
{
    public class Pangrams
    {
        public bool IsPangram(string input)
        {
            //input = input.ToLower();
            int a = 'a';
			int gap = 'a' - 'A';
			int size = 'z' - 'a' + 1;

			HashSet<int> hs = new HashSet<int>();

			for (int i = 0; i < input.Length; i++)
			{
				if (input[i] == ' ')
				{
					continue;
				}

				int c = input[i];
				if (input[i] >= a)
				{
					c = c - gap;
				}
				hs.Add(c);
			}

			if (hs.Count == size)
			{
				Console.WriteLine("pangram");
                return true;
			}
			else
			{
				Console.WriteLine($"not pangram");
                return false;
			}
        }
    }
}
