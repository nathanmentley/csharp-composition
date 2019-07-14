using System;

using example.Core;

namespace example.Units.Common
{
    public interface MHealer: MComposable
    {
        public void Heal(MAttackable target)
        {
            target.IncrementHealth();
        }
    }
}

