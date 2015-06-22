
using System.Collections.Generic;
using System.Linq;

namespace Katas.CodeWars
{
    public class PlusOneArray
    {
        public static int[] UpArray(int[] numbers)
        {
            List<int> numberList = numbers.ToList();
            if (!numberList.Any() || numberList.Any(x => x < 0) || numberList.Any(x => x > 9)) return null;
            for (int i = numberList.Count; i > 0; i--)
            {
                int index = i - 1;
                if (numberList[index] < 9)
                {
                    numberList[index] = numberList[index] + 1;
                    break;
                }
                else
                {
                    numberList[index] = 0;
                    if (index == 0)
                    {
                        numberList.Insert(0, 1);
                    }
                }
            }
            return numberList.ToArray();
        }
    }
}