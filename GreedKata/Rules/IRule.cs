﻿using System.Collections.Generic;

namespace GreedKata.Rules
{
    public interface IRule
    {
        RuleResult Score(List<int> dice);
    }
}
