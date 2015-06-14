using System;
using System.Globalization;

namespace Katas.CodeWars
{
    public class DigPow
    {
        public static long DigitPowers(int n, int p)
        {
            long result = -1;
            string numbers = n.ToString();
            double powsum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                double pow = p + i;
                powsum += Math.Pow(long.Parse(numbers[i].ToString()), pow);
            }

            if (long.Parse(powsum.ToString(CultureInfo.InvariantCulture))%n == 0)
            {
                result = long.Parse(powsum.ToString(CultureInfo.InvariantCulture))/n;
            }

            return result;
        }
    }
}