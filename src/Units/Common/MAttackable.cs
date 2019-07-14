using System;

using example.Core;

namespace example.Units.Common
{
    public interface MAttackable: MComposable
    {
        private UInt32 _health
        {
            get => GetField<UInt32>();
            set => SetField(value);
        }

        internal Boolean IncrementHealth()
        {
            if (!IsHealthFull())
            {
                _health++;
                return true;
            }

            return false;
        }

        internal Boolean DecrementHealth()
        {
            if (!IsHealthEmpty())
            {
                _health--;
                return true;
            }

            return false;
        }

        public void InitHealth(UInt32 value)
        {
            _health = value;
        }

        public Boolean IsHealthFull()
        {
            return _health == UInt32.MaxValue;
        }

        public Boolean IsHealthEmpty()
        {
            return _health == UInt32.MinValue;
        }
    }
}

