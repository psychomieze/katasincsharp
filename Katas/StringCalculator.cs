#region

using System;
using System.Collections.Generic;
using System.Linq;

#endregion

namespace Katas
{
    public class StringCalculator
    {
        public static int Add(string numberString)
        {
            string delimiter = ",";
            if (numberString == string.Empty)
            {
                return 0;
            }
            List<string> delimiterStrings = new List<string>();
            if (numberString.StartsWith("//"))
            {
                string[] tempDelimiters = numberString.Split(new[] {'\n'}, 2)
                    .First()
                    .Split(new[] {"]["}, StringSplitOptions.None);
                string[] replacementStrings = {"/", "\n", "[", "]"};
                delimiterStrings.AddRange(
                    tempDelimiters.Select(s => replacementStrings.Aggregate(s, (c1, c2) => c1.Replace(c2, string.Empty))));
                numberString = numberString.Split(new[] {'\n'}, 2).Last();
            }
            else
            {
                delimiterStrings.Add(delimiter);
            }
            delimiterStrings.Add("\n");
            string[] numbers = numberString.Split(delimiterStrings.ToArray(), StringSplitOptions.None);
            string negatives = string.Join(",",
                numbers.Select(int.Parse).Where(i => i < 0).Select(s => s.ToString()).ToArray());
            if (negatives.Length > 0)
            {
                throw new Exception("Not allowed" + negatives);
            }
            return numbers.Select(int.Parse).Where(i => i < 1001).Sum();
        }
    }
}