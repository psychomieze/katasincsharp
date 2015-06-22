using System;
using System.Linq;

namespace Katas.CodeWars
{
    public class PatternCompletion
    {
        public string Pattern(int n)
        {
            string result = "";
            for (int i = 1; i <= n; i++)
            {
                string append = string.Concat(Enumerable.Repeat(i, i));
                result = result + "\n" + append;
            }
            return result.Trim('\n');
        }
    }
}