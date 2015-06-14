#region

#endregion

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using log4net;

namespace Katas
{
    public class StringCalculator
    {
        private ILog Log { get; }
        private IWebservice Webservice { get; }

        public StringCalculator(IWebservice webservice, ILog log = null)
        {
            Log = log ?? LogManager.GetLogger(typeof (StringCalculator));
            Webservice = webservice;
        }


        public int Add(string numbersString)
        {
            if (string.IsNullOrEmpty(numbersString)) return 0;
            string[] numbers = GetNumbers(numbersString);
            int sum = SumIfAllArePositive(numbers);
            LogResult(sum);
            return sum;
        }

        private string[] GetNumbers(string numbersString)
        {
            string[] delimiters = HandleDelimiters(ref numbersString);
            return numbersString.Split(delimiters, StringSplitOptions.None);
        }

        private void LogResult(int sum)
        {
            try
            {
                Log.Info(sum.ToString());
            }
            catch (Exception e)
            {
                Webservice.Notify(e.Message);
            }
        }

        private string[] HandleDelimiters(ref string numbersString)
        {
            string[] delimiters = new[] {"\n"};
            Match match = Regex.Match(numbersString, @"^//(.*?)\n");
            if (match.Success)
            {
                IEnumerable<string> additionalDelimiters = GetAdditionalDelimitersFromMatch(match);
                delimiters = delimiters.Concat(additionalDelimiters).ToArray();
                numbersString = numbersString.Substring(match.Groups[0].Length);
            }
            else
            {
                // default delimiter
                delimiters = delimiters.Concat(new string[] {","}).ToArray();
            }
            return delimiters;
        }

        private IEnumerable<string> GetAdditionalDelimitersFromMatch(Match match)
        {
            string[] delimiters;
            string matchString = match.Groups[match.Groups.Count - 1].Value;
            matchString = matchString.Trim(new[] {'[', ']'});
            delimiters = matchString.Split(new[] {"]["}, StringSplitOptions.None);
            return delimiters;
        }

        private static int SumIfAllArePositive(string[] numbers)
        {
            List<int> negatives = new List<int>();
            int sum = 0;
            foreach (string numberAsString in numbers)
            {
                int number = int.Parse(numberAsString);
                if (number < 0)
                {
                    negatives.Add(number);
                }
                else if (number < 1001)
                {
                    sum += number;
                }
            }
            if (negatives.Any())
            {
                throw new Exception(string.Format("Not allowed: {0}", string.Join(",", negatives)));
            }
            return sum;
        }
    }
}