using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Katas.CodeWars
{
    public class Noobifier
    {
        public static string N00bify(string text)
        {
            string noobString = PrependLol(text);
            noobString = DoReplacements(noobString);
            noobString = PrependOmg(text, noobString);
            noobString = HandleUpperCaseTransformations(text, noobString);
            noobString = HandleQuestionAndExclamationMarks(noobString);
            return noobString;
        }

        private static string HandleQuestionAndExclamationMarks(string noobString)
        {
            if (noobString.Contains("?") || noobString.Contains("!"))
            {
                string question = "?";
                string exclamation = "!";
                int count = noobString.Count(char.IsWhiteSpace);
                for (int i = 0; i < count; i++)
                {
                    if (i%2 == 0)
                    {
                        exclamation += "1";
                    }
                    else
                    {
                        exclamation += "!";
                    }
                    question += "?";
                }
                noobString = noobString.Replace("?", question).Replace("!", exclamation);
            }
            return noobString;
        }

        private static string HandleUpperCaseTransformations(string text, string noobString)
        {
            noobString = ShouldBeFullyUpperCased(text) ? noobString.ToUpper() : EverySecondWordToUpperCase(noobString);
            return noobString;
        }

        private static bool ShouldBeFullyUpperCased(string text)
        {
            return text.ToLower().StartsWith("h");
        }

        private static string EverySecondWordToUpperCase(string noobString)
        {
            string[] strings = noobString.Split(' ');
            for (int i = 0; i < strings.Length; i++)
            {
                if (i%2 != 0)
                {
                    strings[i] = strings[i].ToUpper();
                }
            }
            return string.Join(" ", strings);
        }

        private static string PrependOmg(string text, string noobString)
        {
            if (noobString.Length > 32)
            {
                noobString = noobString.Insert(ShouldPrependLol(text) ? 4 : 0, "OMG ");
            }
            return noobString;
        }

        private static string PrependLol(string text)
        {
            if (ShouldPrependLol(text))
            {
                text = text.Insert(0, "LOL ");
            }
            return text;
        }

        private static bool ShouldPrependLol(string text)
        {
            return text.ToLower().StartsWith("w");
        }

        private static string DoReplacements(string s)
        {
            Dictionary<string, string> dictionary = new Dictionary<string, string>
            {
                {"too", "2"},
                {"to", "2"},
                {"fore", "4"},
                {"for", "4"},
                {"be", "b"},
                {"Be", "B"},
                {"are", "r"},
                {"you", "u"},
                {"please", "plz"},
                {"people", "ppl"},
                {"really", "rly"},
                {"have", "haz"},
                {"know", "no"},
                {"s", "z"},
                {"oo", "00"},
                {"\\.", ""},
                {"\\,", ""},
                {"\\'", ""}
            };
            foreach (KeyValuePair<string, string> keyValuePair in dictionary)
            {
                string pattern = keyValuePair.Key;
                Regex regex = new Regex(@pattern, RegexOptions.IgnoreCase);
                s = regex.Replace(s, keyValuePair.Value);
            }
            return s;
        }
    }
}