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
        private List<IRule> rules;

        public Greed()
        {
            this.rules = BuildRules();
        }

        private List<IRule> BuildRules()
        {
            return new List<IRule>
            {
                new SingleDiceRule(1, 100),
            };
        }

        public int Score(List<int> dice)
        {
            int score = 0;

            rules.ForEach(r => score += r.Score(dice));

            return score;
        }
    }
}
