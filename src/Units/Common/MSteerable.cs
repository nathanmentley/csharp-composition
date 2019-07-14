using System;

using example.Core;

namespace example.Units.Common
{
    public interface MSteerable: IComposable
    {
        private Int32 _steeringPosition
        {
            get
            {
                return GetField<Int32>("MSteerable_direction");
            }
            set
            {
                SetField("MSteerable_direction", value);
            }
        }

        private Boolean IsFullyLeft()
        {
            return _steeringPosition == Int32.MinValue;
        }

        private Boolean IsFullyRight()
        {
            return _steeringPosition == Int32.MaxValue;
        }

        public void TurnLeft()
        {
            if(!IsFullyLeft())
            {
                _steeringPosition--;
            }
        }

        public void TurnRight()
        {
            if(!IsFullyRight())
            {
                _steeringPosition++;
            }
        }
    }
}
