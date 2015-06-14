#region

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Serialization;

#endregion

namespace Katas
{
    public class PotterPricing
    {
        public static double GetPrice(int[] books)
        {
            if (books.Length > 0)
            {
                IEnumerable<int> distinct = books.Distinct();
                IEnumerable<int> enumerable = distinct as int[] ?? distinct.ToArray();
                int count = enumerable.Count();

                double sum = 0;
                switch (count)
                {
                    case 1:
                        sum = 8*1;
                        break;
                    case 2:
                        sum = 8*2*0.95;
                        break;
                    case 3:
                        sum = 8*3*0.9;
                        break;
                    case 4:
                        sum = 8*4*0.8;
                        break;
                    case 5:
                        sum = 8*5*0.75;
                        break;
                }
                double sam = 0;
                if (distinct.Count() > 4)
                {
                    int[] boox = books;
                    int i = 0;

                    foreach (var book in distinct)
                    {
                        if (i < 4)
                        {
                            int numIndex = Array.IndexOf(boox, book);
                            boox = boox.Where((val, idx) => idx != numIndex).ToArray();
                        }
                        i++;
                    }
                    if (boox.Length > 0)
                    {
                        sam += PotterPricing.GetPrice(boox);
                    }
                }
                foreach (var book in distinct)
                {
                    int numIndex = Array.IndexOf(books, book);
                    books = books.Where((val, idx) => idx != numIndex).ToArray();
                }
                double som = 0;
                if (books.Length > 0)
                {
                   som = PotterPricing.GetPrice(books);
                }
                if (sam != 0 && som != 0)
                {
                    sum += Math.Min(sam, som);
                } 

                return sum;
                //    return Math.Min(sam, sum);
            }
            return 0;
        }
    }
}