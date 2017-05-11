using System.Collections.Generic;

namespace GreedKata.Rules
{
    public interface IRule
    {
        int Score(List<int> dice);
    }
}
