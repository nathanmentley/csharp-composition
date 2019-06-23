using System;

using example.Core;

namespace example.Units.Common
{
    public interface MFuelable: IComposable {}
    static public class MFuelableEx {
        private const String TANK_VALUE = "MFuelable_tank_value";

        //private setter
        private static void SetTank(this MFuelable thing, UInt32 value) {
            thing.SetField(MFuelableEx.TANK_VALUE, value);
        }

        //increment tank by 1.
        internal static Boolean IncrementTank(this MFuelable thing) {
            if (!thing.IsTankFull()) {
                thing.SetTank(thing.GetTankValue() + 1);
                return true;
            }

            return false;
        }

        //decrement tank by 1
        internal static Boolean DecrementTank(this MFuelable thing) {
            if (!thing.IsTankEmpty()) {
                thing.SetTank(thing.GetTankValue() - 1);
                return true;
            }

            return false;
        }

        //setup initial tank value.
        public static void InitTank(this MFuelable thing, UInt32 value) {
            thing.SetTank(value);
        }

        //get tank value
        public static UInt32 GetTankValue(this MFuelable thing) {
            return thing.GetField<UInt32>(MFuelableEx.TANK_VALUE);
        }
        //check if tank is full
        public static Boolean IsTankFull(this MFuelable thing) {
            return thing.GetTankValue() == UInt32.MaxValue;
        }
        //check if tank is empty
        public static Boolean IsTankEmpty(this MFuelable thing) {
            return thing.GetTankValue() == UInt32.MinValue;
        }
    }
}
