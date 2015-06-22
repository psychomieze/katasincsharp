using System.Linq;

namespace Katas.CodeWars
{
    public class SharpNumber
    {
        public static int FindSharpNumber(int[] ints)
        {
            return ints.GroupBy(i => i).OrderByDescending(grp => grp.Count())
                .Select(grp => grp.Key).First();
        }
    }
}