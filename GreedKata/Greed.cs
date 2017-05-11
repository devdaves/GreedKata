using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GreedKata.Rules;

namespace GreedKata
{
    public class Greed
    {
        private readonly List<IRule> rules;

        public Greed()
        {
            this.rules = BuildRules();
        }

        private List<IRule> BuildRules()
        {
            return new List<IRule>
            {
                new StraightRule(),
                new ThreePairsRule(),
                new XOfAKindRule(6, 8),
                new XOfAKindRule(5, 4),
                new XOfAKindRule(4, 2),
                new TripleScoreRule(),
                new SingleDiceRule(1, 100),
                new SingleDiceRule(5, 50)
            };
        }

        public int Score(List<int> dice)
        {
            int score = 0;

            rules.ForEach(r =>
            {
                var result = r.Score(dice);
                score += result.Score;
                result.DiceUsed.ForEach(du => dice.Remove(du));
            });

            return score;
        }
    }
}
