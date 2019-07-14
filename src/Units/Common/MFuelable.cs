using System;

using example.Core;

namespace example.Units.Common
{
    public interface MFuelable: IComposable {
        private UInt32 _tank
        {
            get
            {
                return GetField<UInt32>("MFuelable_tank_value");
            }
            set
            {
                SetField("MFuelable_tank_value", value);
            }
        }

        //setup initial tank value.
        public void InitTank(UInt32 value)
        {
            _tank = value;
        }

        //increment tank by 1.
        internal Boolean IncrementTank()
        {
            if (!IsTankFull())
            {
                _tank++;
                return true;
            }

            return false;
        }

        //decrement tank by 1
        internal Boolean DecrementTank()
        {
            if (!IsTankEmpty())
            {
                _tank--;
                return true;
            }

            return false;
        }

        //check if tank is full
        public Boolean IsTankFull()
        {
            return _tank == UInt32.MaxValue;
        }

        //check if tank is empty
        public Boolean IsTankEmpty()
        {
            return _tank == UInt32.MinValue;
        }

        //get tank value
        public UInt32 GetTankValue() => _tank;
    }
}
