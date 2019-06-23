using System;

using example.Units.Common;

namespace example.Units
{
    class House: ABuilding, MStorage, MAttackable
    {
        public House(): base("710 Emmet Ypsilanti Mi 48197") {}
    }
}

