namespace Katas.CodeWars
{
    public class MultiplesOfThreeAndFive
    {
        public static int Solution(int value)
        {
            int sum = 0;
            for (int i = value-1; i > 0; i--)
            {
                if (i%3 == 0 || i%5 == 0)
                {
                    sum += i;
                }
            }

            return sum;
        }
    }
}