using System.Collections.Generic;
using System.Linq;

public class BackwardsPrimes
{

    public static string backwardsPrime(long start, long end)
    {
        HashSet<long> primes = new HashSet<long>();
        if (start % 2 == 0) start++;
        for (long i = start; i <= end; i += 2)
        {
            if (!IsPrime(i)) continue;
            long reverseNumber = ReverseNumber(i);
            if ((i != reverseNumber) && IsPrime(reverseNumber))
            {
                primes.Add(i);
            }
        }
        return string.Join(" ", primes.OrderBy(l => l));
    }

    private static long ReverseNumber(long sum)
    {
        long reverse = 0;
        while (sum > 0)
        {
            long rest = sum % 10;
            reverse = reverse * 10 + rest;
            sum = sum / 10;
        }
        return reverse;
    }


    private static bool IsPrime(long number)
    {
        if (number < 3)
        {
            return number == 2;
        }
        if (number % 2 == 0)
        {
            return false;
        }
        for (int i = 3; (i * i) <= number; i += 2)
        {
            if ((number % i) == 0)
            {
                return false;
            }
        }
        return true;
    }
}