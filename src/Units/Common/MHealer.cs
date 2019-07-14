using System;

using example.Core;

namespace example.Units.Common
{
    public interface MHealer: IComposable
    {
        public void Heal(MAttackable target)
        {
            target.IncrementHealth();
        }
    }
}

