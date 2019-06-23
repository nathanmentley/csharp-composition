using System;

using example.Core;
using example.Units.Common;

namespace example.Units
{
    class FuelSemiTruck: ATransport, MSteerable, MFuelable, MFueler, MMovable, MAttackable
    {
        public FuelSemiTruck(): base("FuelSemiTruck") {}
    }
}

