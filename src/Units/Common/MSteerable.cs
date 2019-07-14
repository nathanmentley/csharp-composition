using System;

using example.Core;

namespace example.Units.Common
{
    public interface MSteerable: MComposable
    {
        private Int32 _steeringPosition
        {
            get => GetField<Int32>();
            set => SetField(value);
        }

        private Boolean IsTurningFullyLeft()
        {
            return _steeringPosition == Int32.MinValue;
        }

        private Boolean IsTurningFullyRight()
        {
            return _steeringPosition == Int32.MaxValue;
        }

        public void TurnLeft()
        {
            if(!IsTurningFullyLeft())
            {
                _steeringPosition--;
            }
        }

        public void TurnRight()
        {
            if(!IsTurningFullyRight())
            {
                _steeringPosition++;
            }
        }
    }
}
