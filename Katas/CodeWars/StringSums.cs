using System;
using System.Collections.Generic;
using System.Linq;

namespace Katas.CodeWars
{
    public class StringSums
    {
        public static string SumStrings(string a, string b)
        {
            string sum = "";

            int cnt = Math.Max(a.Length, b.Length);

            List<int> aChars = a.PadLeft(cnt, '0').ToArray().Select(x => int.Parse(x.ToString())).ToList();
            List<int> bChars = b.PadLeft(cnt, '0').ToArray().Select(x => int.Parse(x.ToString())).ToList();

            int remainder = 0;
            for (int i = cnt-1; i >= 0; i--)
            {
                int digitSum = 0;
                if (i <= aChars.Count()-1 && i <= bChars.Count()-1)
                {
                    digitSum = aChars[i] + bChars[i] + remainder;
                    if (digitSum >= 10)
                    {
                        digitSum = digitSum - 10;
                        remainder = 1;
                    }
                    else
                    {
                        remainder = 0;
                    }
                }
                sum = sum.Insert(0, digitSum.ToString());
            }
            if (remainder == 1)
            {
                sum = sum.Insert(0, "1");
            }
            return sum;
        }
    }
}