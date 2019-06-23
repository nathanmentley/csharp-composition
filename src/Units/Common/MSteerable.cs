using System;

using example.Core;

namespace example.Units.Common
{
    public interface MSteerable: IComposable {}
    static public class MSteerableEx {
        private const String DIRECTION = "MSteerable_direction";

        private static Boolean IsFullyLeft(this MSteerable thing) {
            return thing.GetSteeringPosition() == Int32.MinValue;
        }
        private static Boolean IsFullyRight(this MSteerable thing) {
            return thing.GetSteeringPosition() == Int32.MaxValue;
        }

        public static void TurnLeft(this MSteerable thing) {
            if(!thing.IsFullyLeft()) {
                thing.SetSteeringPosition(thing.GetSteeringPosition() - 1);
            }
        }
        public static void TurnRight(this MSteerable thing) {
            if(!thing.IsFullyRight()) {
                thing.SetSteeringPosition(thing.GetSteeringPosition() + 1);
            }
        }
        public static Int32 GetSteeringPosition(this MSteerable thing) {
            return thing.GetField<Int32>(MSteerableEx.DIRECTION);
        }
        public static void SetSteeringPosition(this MSteerable thing, Int32 value) {
            thing.SetField(MSteerableEx.DIRECTION, value);
        }
    }
}
