using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreedKata.Rules
{
    public class XOfAKindRule : IRule
    {
        private readonly int xAmount;
        private readonly int multiplier;

        public XOfAKindRule(int xAmount, int multiplier)
        {
            this.xAmount = xAmount;
            this.multiplier = multiplier;
        }


        public RuleResult Score(List<int> dice)
        {
            var result = new RuleResult();
            var groupedDice = dice.GroupBy(x => x);

            foreach (var groupedDie in groupedDice)
            {
                if (groupedDie.Count() >= xAmount)
                {
                    result.Score += TripleScoreRule.ScoringMap[groupedDie.Key] * this.multiplier;
                    result.DiceUsed.AddRange(groupedDie.Take(this.xAmount));
                }
            }

            return result;
        }
    }
}
