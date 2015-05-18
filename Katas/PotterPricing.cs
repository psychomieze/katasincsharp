#region

using System.Collections.Generic;
using System.Linq;

#endregion

namespace Katas
{
    public class PotterPricing
    {
        public static double GetPrice(int[] books)
        {
            if (books.Length > 0)
            {
                if (books.Length > 1 && books.Distinct().Count() == books.Length)
                {
                    switch (books.Distinct().Count())
                    {
                        case 2:
                            return 8*2*0.95;
                        case 3:
                            return 8*3*0.9;
                        case 4:
                            return 8*4*0.8;
                        case 5:
                            return 8*5*0.75;
                    }
                }
                double sum = 0;
                if (books.Distinct().Count() > 1)
                {
                    switch (books.Distinct().Count())
                    {
                        case 2:
                           sum =  8 * 2 * 0.95;
                            break;
                        case 3:
                            sum = 8 * 3 * 0.9;
                            break;
                        case 4:
                            sum = 8 * 4 * 0.8;
                            break;
                        case 5:
                            sum = 8 * 5 * 0.75;
                            break;
                    }
                    int booksLeft = books.Length - books.Distinct().Count();
                    sum += booksLeft*8;
                    return sum;
                }

                return 8*books.Length;
            }
            return 0;
        }
    }
}


