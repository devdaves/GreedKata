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

        public int Score(List<int> dice)
        {
            if (dice[0] == this.value)
            {
                return this.score;
            }

            return 0;
        }
    }
}
