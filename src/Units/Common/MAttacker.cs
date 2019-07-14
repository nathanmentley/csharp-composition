using System;

using example.Core;

namespace example.Units.Common
{
    public interface MAttacker: MComposable
    {
        public void Attack(MAttackable target) {
            target.DecrementHealth();
        }
    }
}

