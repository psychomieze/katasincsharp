using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Katas
{
    public class Noobifier
    {
        public static string Noobify(string text)
        {
            text = EnhancedReplace(text);
            text = PrependStuff(text);
            string[] strings = text.Split(' ');
            for (int i = 0; i < strings.Length; i++)
            {
                if (i%2 != 0)
                {
                    strings[i] = strings[i].ToUpper();
                }
            }
            return string.Join(" ", strings);
        }

        private static string PrependStuff(string text)
        {
            if (ShouldPrependLol(text))
            {
                text = PrependLol(text);
                text = PrependOmg(text, true);
            }
            else
            {
                text = PrependOmg(text, false);
            }
            return text;
        }

        private static string PrependOmg(string text, bool loled)
        {
            if (text.Length >= 32)
            {
                if (loled)
                {
                    text = text.Insert(4, "OMG ");
                }
                else
                {
                    text = "OMG " + text;
                }
            }
            return text;
        }

        private static string PrependLol(string text)
        {
            {
                text = "LOL " + text;
            }
            return text;
        }

        private static bool ShouldPrependLol(string text)
        {
            return text.ToLower().StartsWith("w");
        }

        public static string EnhancedReplace(string text)
        {
            Dictionary<string, string> dictionary = new Dictionary<string, string>
            {
                {"too", "2"},
                {"to", "2"},
                {"fore", "4"},
                {"for", "4"},
                {"oo", "00"},
                {"be", "b"},
                {"are", "r"},
                {"you", "u"},
                {"please", "plz"},
                {"people", "ppl"},
                {"really", "rly"},
                {"have", "haz"},
                {"know", "no"},
            };
            foreach (KeyValuePair<string, string> keyValuePair in dictionary)
            {
                Regex regex = new Regex(@keyValuePair.Key, RegexOptions.IgnoreCase);
                text = regex.Replace(text, keyValuePair.Value);
            }
            text = text.Replace('s', 'z');
            text = text.Replace('S', 'Z');
            return text;
        } 
    }
}