using System;

using example.Core;

namespace example.Units.Common
{
    public interface MHealer: IComposable {}
    static public class MHealerEx {
        public static void Heal(this MHealer thing, MAttackable target) {
            target.IncrementHealth();
        }
    }
}

