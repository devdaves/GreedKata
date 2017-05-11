using System.Collections.Generic;

namespace GreedKata.Rules
{
    public class SingleDiceRule : IRule
    {
        private readonly int value;
        private readonly int score;

        public SingleDiceRule(int value, int score)
        {
            this.value = value;
            this.score = score;
        }

        public RuleResult Score(List<int> dice)
        {
            var result = new RuleResult();

            dice.ForEach(d =>
            {
                if (d == this.value)
                {
                    result.Score += this.score;
                    result.DiceUsed.Add(d);
                }
            });

            return result;
        }
    }
}
