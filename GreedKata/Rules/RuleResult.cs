using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreedKata.Rules
{
    public class RuleResult
    {
        public RuleResult()
        {
            this.DiceUsed = new List<int>();
        }

        public List<int> DiceUsed { get; set; }

        public int Score { get; set; }
    }
}
