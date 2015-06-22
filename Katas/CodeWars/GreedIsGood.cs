using System.Collections.Generic;
using System.Linq;

namespace Katas.CodeWars
{
    public class GreedIsGood
    {
        public static int Score(int[] ints)
        {
            int[] dice = new int[6] {0,0,0,0,0,0};
            int score = 0;
            
            GroupDiceByValue(ints, dice);

            score = TripleScoring(dice, score);
            score += dice[0]*100;
            score += dice[4]*50;

            return score;
        }

        private static int TripleScoring(int[] dice, int score)
        {
            Dictionary<int, int> tripleScoreMap = new Dictionary<int, int>
            {
                {0, 1000},
                {5, 600},
                {4, 500},
                {3, 400},
                {2, 300},
                {1, 200}
            };

            foreach (KeyValuePair<int, int> pair in tripleScoreMap.Where(pair => dice[pair.Key] >= 3))
            {
                score += pair.Value;
                dice[pair.Key] = dice[pair.Key] - 3;
            }
            return score;
        }

        private static void GroupDiceByValue(int[] ints, int[] dice)
        {
            foreach (int t in ints)
            {
                dice[t - 1]++;
            }
        }
    }
}