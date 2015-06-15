#region

using System;
using System.Collections.Generic;
using System.Linq;
using log4net.DateFormatter;

#endregion

namespace Katas
{
    public class PotterPricing
    {
        public static double GetPrice(int[] books)
        {
            if (books.Length < 1) return 0;

            List<int> distinct = books.Distinct().ToList();
            int count = distinct.Count();

            double sumOfFourBookSplit = CalculateSumBySplittingAfterFourBooks(books, distinct);
            double sumOfNormalSplit = CalculateSumWithAsManyDistinctBooksAsPossible(books, count, distinct);

            return GetLowerSum(sumOfFourBookSplit, sumOfNormalSplit);
        }

        private static double CalculateSumWithAsManyDistinctBooksAsPossible(int[] books, int count, List<int> distinct)
        {
            double sum = SumPerBookCount(count);
            books = RemoveDistinctBooksFromArray(books, distinct);
            double sumOfRemainingBooks = GetSumForBooks(books);
            double sumOfNormalSplit = sum + sumOfRemainingBooks;
            return sumOfNormalSplit;
        }

        private static double CalculateSumBySplittingAfterFourBooks(int[] books, List<int> distinct)
        {
            double sumOfFirstFourBooks = HandleFirstFourBooks(distinct);
            double sumOfBooksExceptTheFirstFourDistinct = HandleMoreThanFourBooks(books, distinct);
            double sumOfFourBookSplit = sumOfFirstFourBooks + sumOfBooksExceptTheFirstFourDistinct;
            return sumOfFourBookSplit;
        }

        private static double HandleFirstFourBooks(List<int> distinct)
        {
            List<int> firstFour = new List<int>();
            if (distinct.Count() > 4)
            {
                for (int i = 0; i < 4; i++)
                {
                    firstFour.Add(distinct[i]);
                }
            }
            return GetSumForBooks(firstFour.ToArray());
        }

        private static int[] RemoveDistinctBooksFromArray(int[] books, IEnumerable<int> distinct)
        {
            return distinct.Aggregate(books, RemoveEntryFromArray);
        }

        private static double HandleMoreThanFourBooks(int[] books, List<int> distinct)
        {
            double sam = 0;
            if (distinct.Count() > 4)
            {
                int[] boox = RemoveFirstFourBooks(books, distinct);
                sam = GetSumForBooks(boox);
            }
            return sam;
        }

        private static int[] RemoveFirstFourBooks(int[] books, IEnumerable<int> distinct)
        {
            int[] boox = books;
            int i = 0;

            foreach (int book in distinct)
            {
                if (i < 4)
                {
                    boox = RemoveEntryFromArray(boox, book);
                }
                i++;
            }
            return boox;
        }

        private static double GetLowerSum(double sam, double som)
        {
            double sum = 0;
            if (sam != 0 && som != 0)
            {
                sum = Math.Min(sam, som);
            }
            else if (sam > 0)
            {
                sum = sam;
            }
            else
            {
                sum = som;
            }
            return sum;
        }

        private static double GetSumForBooks(int[] books)
        {
            double som = 0;
            if (books.Length > 0)
            {
                som = PotterPricing.GetPrice(books);
            }
            return som;
        }

        private static int[] RemoveEntryFromArray(int[] boox, int book)
        {
            int numIndex = Array.IndexOf(boox, book);
            boox = boox.Where((val, idx) => idx != numIndex).ToArray();
            return boox;
        }

        private static double SumPerBookCount(int count)
        {
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
            return sum;
        }
    }
}