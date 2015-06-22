using System.Collections.Generic;
using System.Linq;

namespace Katas.CodeWars
{
    public class GoodAndEvil
    {
        private const int Hobbits = 0;
        private const int Men = 1;
        private const int Elves = 2;
        private const int Dwarves = 3;
        private const int Eagles = 4;
        private const int Wizards = 5;

        private const int HobbitsScore = 1;
        private const int MenScore = 2;
        private const int ElvesScore = 3;
        private const int DwarvesScore = 3;
        private const int EaglesScore = 4;
        private const int WizardsScore = 10;

        private const int Orcs = 0;
        private const int EvilMen = 1;
        private const int Wargs = 2;
        private const int Goblins = 3;
        private const int UrukHai = 4;
        private const int Trolls = 5;
        private const int EvilWizards = 6;

        private const int OrcsScore = 1;
        private const int EvilMenScore = 2;
        private const int WargsScore = 2;
        private const int GoblinsScore = 2;
        private const int UrukHaiScore = 3;
        private const int TrollsScore = 5;
        private const int EvilWizardsScore = 10;

        private static Dictionary<int, int> GoodScores
        {
            get
            {
                Dictionary<int, int> goodScores = new Dictionary<int, int>
                {
                    {Hobbits, HobbitsScore},
                    {Men, MenScore},
                    {Elves, ElvesScore},
                    {Dwarves, DwarvesScore},
                    {Eagles, EaglesScore},
                    {Wizards, WizardsScore},
                };
                return goodScores;
            }
        }

        private static Dictionary<int, int> EvilScores
        {
            get
            {
                Dictionary<int, int> evilScores = new Dictionary<int, int>
                {
                    {Orcs, OrcsScore},
                    {EvilMen, EvilMenScore},
                    {Wargs, WargsScore},
                    {Goblins, GoblinsScore},
                    {UrukHai, UrukHaiScore},
                    {Trolls, TrollsScore},
                    {EvilWizards, EvilWizardsScore}
                };
                return evilScores;
            }
        }

        public static string GoodVsEvil(string good, string evil)
        {
            int sumGood = SumFromStringAndScoreDictionary(good, GoodScores);
            int sumEvil = SumFromStringAndScoreDictionary(evil, EvilScores);

            if (sumEvil > sumGood)
            {
                return "Battle Result: Evil eradicates all trace of Good";
            }

            if (sumGood > sumEvil)
            {
                return "Battle Result: Good triumphs over Evil";
            }
            
            return "Battle Result: No victor on this battle field";
        }

        
        private static int SumFromStringAndScoreDictionary(string peopleOnBattlefield, Dictionary<int, int> scores)
        {
            return peopleOnBattlefield.Split(' ').Select((x, i) => scores[i] * int.Parse(x)).Sum();
        }
    }
}