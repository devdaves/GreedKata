using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreedKata.Rules
{
    public class TripleScoreRule : IRule
    {
        public static readonly Dictionary<int, int> ScoringMap = new Dictionary<int, int>
        {
            {1,1000 },
            {2,200 },
            {3,300 },
            {4,400 },
            {5,500 },
            {6,600 },
        };

        public RuleResult Score(List<int> dice)
        {
            var result = new RuleResult();
            var groupedDice = dice.GroupBy(x => x);

            foreach (var groupedDie in groupedDice)
            {
                if (groupedDie.Count() >= 3)
                {
                    result.Score += ScoringMap[groupedDie.Key];
                    result.DiceUsed.AddRange(groupedDie.Take(3));
                }
            }
            
            return result;
        }
    }
}
