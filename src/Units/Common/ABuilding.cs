using System;

namespace example.Units.Common
{
    abstract class ABuilding: AEntity
    {
        protected String address { get; private set; }

        protected ABuilding(String _address): base() {
            address = _address;
        }

        public virtual String GetAddress() {
            return address;
        }
    }
}

