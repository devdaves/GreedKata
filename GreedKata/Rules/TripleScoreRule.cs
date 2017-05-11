using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreedKata.Rules
{
    public class TripleScoreRule : IRule
    {
        private readonly int value;
        private readonly int score;

        public TripleScoreRule(int value, int score)
        {
            this.value = value;
            this.score = score;
        }

        public RuleResult Score(List<int> dice)
        {
            var result = new RuleResult();

            if (dice.Count(d => d == this.value) == 3)
            {
                result.Score = this.score;
                result.DiceUsed.AddRange(Enumerable.Range(0,3).Select(x => this.value));
            }

            return result;
        }
    }
}
