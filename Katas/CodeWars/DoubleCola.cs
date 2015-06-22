using System;
using System.Globalization;

namespace Katas.CodeWars
{
    public class DoubleCola
    {
        public static string WhoIsNext(string[] names, long n)
        {
            long component = 1;
            long numberInComponent = n;
            long numberCnt = 5;
            for (long i = 5; numberCnt < n; i *= 2, numberCnt += i)
            {
                component++;
                if (!(numberInComponent < i)) numberInComponent -= i;
            }

            long numberRepeatTimes = Convert.ToInt64(Math.Pow(2, component - 1));
            int currentIndex = 0;
            for (long j = 1; j < numberInComponent; j++)
            {
                if (j % numberRepeatTimes == 0)
                {
                    currentIndex++;
                }
            }
            return names[currentIndex];
        }
    }
}