using System;

using example.Core;

namespace example.Units.Common
{
    public interface MAttacker: IComposable {}
    static public class MAttackerEx {
        public static void Attack(this MAttacker thing, MAttackable target) {
            target.DecrementHealth();
        }
    }
}

