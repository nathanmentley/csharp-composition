using System;

using example.Core;
using example.Units.Common;

namespace example.Units
{
    class GasStation: ABuilding, MFuelable, MFueler, MStorage, MAttackable
    {
        public GasStation(): base("addr 2") {}
    }
}
