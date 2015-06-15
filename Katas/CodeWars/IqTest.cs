namespace Katas.CodeWars
{
    public class IqTest
    {
        public static int Test(string numbers)
        {
            int oddCnt = 0;
            int lastOdd = 0;
            int lastEvn = 0;
            string[] strings = numbers.Split(' ');
            for (int index = 0; index < strings.Length; index++)
            {
                string number = strings[index];
                if (Odd(int.Parse(number)))
                {
                    lastOdd = index;
                    oddCnt++;
                }
                else
                {
                    lastEvn = index;
                }
            }

            if (oddCnt > 1)
            {
                return lastEvn + 1;
            }
            return lastOdd + 1;
        }

        public static bool Odd(int number)
        {
            return number%2 != 0;
        }
    }
}