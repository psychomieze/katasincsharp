using System.Collections.Generic;
using System.Linq;

namespace Katas.CodeWars
{
    public class PalindromeChain
    {
        public static int PalindromeChainLength(int n)
        {
            if (IsPalindrome(n)) return 0;
            long sum = n;

            for (int i = 1;; i++)
            {
                long number = ReverseNumber(sum);
                sum = sum + number;
                if (IsPalindrome(sum))
                {
                    return i;
                }
            }
        }

        private static bool IsPalindrome(long sum)
        {
            return sum == ReverseNumber(sum);
        }

        private static long ReverseNumber(long sum)
        {
            return long.Parse(sum.ToString().Reverse().Aggregate("", (s, c) => s + c));
        }
    }
}