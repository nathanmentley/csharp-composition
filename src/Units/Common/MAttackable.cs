using System;

using example.Core;

namespace example.Units.Common
{
    public interface MAttackable: IComposable {}
    static public class MAttackableEx {
        private const String HEALTH = "MAttackable_health";

        private static void SetHealth(this MAttackable thing, UInt32 value) {
            thing.SetField(MAttackableEx.HEALTH, value);
        }

        internal static Boolean IncrementHealth(this MAttackable thing) {
            if (!thing.IsHealthFull()) {
                thing.SetHealth(thing.GetHealth() + 1);
                return true;
            }

            return false;
        }

        internal static Boolean DecrementHealth(this MAttackable thing) {
            if (!thing.IsHealthEmpty()) {
                thing.SetHealth(thing.GetHealth() - 1);
                return true;
            }

            return false;
        }

        public static void InitHealth(this MAttackable thing, UInt32 value) {
            thing.SetHealth(value);
        }

        public static UInt32 GetHealth(this MAttackable thing) {
            return thing.GetField<UInt32>(MAttackableEx.HEALTH);
        }

        public static Boolean IsHealthFull(this MAttackable thing) {
            return thing.GetHealth() == UInt32.MaxValue;
        }

        public static Boolean IsHealthEmpty(this MAttackable thing) {
            return thing.GetHealth() == UInt32.MinValue;
        }
    }
}

