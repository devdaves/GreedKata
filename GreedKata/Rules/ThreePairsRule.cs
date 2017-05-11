using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreedKata.Rules
{
    public class ThreePairsRule : IRule
    {
        public RuleResult Score(List<int> dice)
        {
            var result = new RuleResult();
            var groupedDice = dice.GroupBy(x => x);

            if (groupedDice.Count(g => g.Count() == 2) == 3)
            {
                result.Score = 800;
            }

            return result;
        }
    }
}
