using System;

using example.Core;

namespace example.Units.Common
{
    public interface MAttackable: MComposable
    {
        private UInt32 _health
        {
            get
            {
                return GetField<UInt32>("MAttackable_health");
            }
            set
            {
                SetField("MAttackable_health", value);
            }
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

