using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreedKata.Rules
{
    public class StraightRule : IRule
    {
        public RuleResult Score(List<int> dice)
        {
            var result = new RuleResult();
            var straight = new List<int> {1, 2, 3, 4, 5, 6};

            if (!straight.Except(dice).Any())
            {
                result.Score = 1200;
                result.DiceUsed = straight;
            }

            return result;
        }
    }
}
