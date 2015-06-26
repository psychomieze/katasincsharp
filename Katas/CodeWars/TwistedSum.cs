using System;

namespace Katas.CodeWars
{
    public static class TwistedSum
    {
        public static long Solution(long n)
        {
            string numberString = n.ToString();
            long sum = 0;
            int sumOfNine = 9 + 8 + 7 + 6 + 5 + 4 + 3 + 2 + 1;
            int lastIndex = numberString.Length-1;
            if (n >= 10)
            {
                for (int i = 0; i < lastIndex; i++)
                {
                    // 123
                    // 1 - 2
                    int currentCharVal = int.Parse(numberString[i].ToString());
                    // 23 - 3
                    long multiplierNumber = long.Parse(numberString.Substring(i + 1));
                    // 24 - 4
                    sum += currentCharVal * (multiplierNumber +1);
                    // 1 =0 - 2 = 1
                    for (long j = currentCharVal - 1; j > 0; j--)
                    {
                        string foo = "1";
                        // 1*10
                        sum += j * long.Parse(foo.PadRight(numberString.Length, '0'));
                    }
                }
                // 45 * 12
                sum += sumOfNine * long.Parse(numberString.Substring(0, lastIndex));
            }
            // 3
            sum += LastDigitSum(numberString, lastIndex);
            return sum;
        }

        private static long LastDigitSum(string numberString, int lastIndex)
        {
            long sum = 0;
            for (int k = 0; k <= int.Parse(numberString[lastIndex].ToString()); k++)
            {
                sum += k;
            }
            return sum;
        }
    }
}