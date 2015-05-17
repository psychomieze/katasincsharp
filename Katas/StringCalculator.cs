using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Katas
{
    public class StringCalculator
    {
        public int Add(string numberString)
        {
            string delimiter = ",";
            if (numberString == string.Empty)
            {
                return 0;
            }

            Match match = Regex.Match(numberString, @"//[\[]?(.*?)[\]]?\n", RegexOptions.IgnoreCase);
            if (match.Success)
            {
                delimiter = match.Groups[1].Value;
                numberString = numberString.Replace(match.Groups[0].Value, "");
            }
            string[] delimiters = delimiter.Split(']', '[');
            string[] delimiterStrings = {
                "\n"
            };
            delimiterStrings = delimiterStrings.Concat(delimiters).ToArray();

            string[] strings = numberString.Split(delimiterStrings, StringSplitOptions.None);
            List<int> negatives = new List<int>();
            int sum = 0;
            foreach (int number in strings.Select(int.Parse))
            {
                if (number < 0)
                {
                    negatives.Add(number);
                } else if(number > 1000)
                {
                }
                else
                {
                    sum += number;
                }
            }
            if (negatives.Any())
            {
                throw new Exception("Not allowed: " + string.Join(" ", negatives));
            }
            return sum;
        }
    }
}