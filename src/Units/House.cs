using System;

using example.Units.Common;

namespace example.Units
{
    class House: ABuilding, MStorage, MAttackable
    {
        public House(): base("addr 1") {}
    }
}

