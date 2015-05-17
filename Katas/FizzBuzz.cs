using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Katas
{
    public class FizzBuzz
    {
        public string FizzBuzzMe(int number)
        {
            if (number%3 == 0 && number%5 == 0)
            {
                return "FizzBuzz";
            }
            if (number%5 == 0)
            {
                return "Buzz";
            }
            if (number%3 == 0)
            {
                return "Fizz";
            }
            return number.ToString();
        }

        public List<string> GetList(int max)
        {
            List<string> resultList = new List<string>();
            for (int i = 1; i <= max; i++)
            {
                resultList.Add(FizzBuzzMe(i));
            }
            return resultList;
        }
    }
}
