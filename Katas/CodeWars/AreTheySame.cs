using System;
using System.Collections.Generic;
using System.Linq;

namespace Katas.CodeWars
{
    public class AreTheySame
    {
        public static bool Comp(int[] a, int[] b)
        {
            if (a == null || b == null) return false;
            if (a.Length == 0 || b.Length == 0)
            {
                return a.Length == 0 && b.Length == 0;
            }

            int[] squares = a.Select(x => Convert.ToInt32(Math.Pow(x, 2))).ToArray();
            IEnumerable<int> diff1 = squares.Except(b);
            IEnumerable<int> diff2 = b.Except(squares);
            return !diff1.Any() && !diff2.Any();
        }
    }
}