using System;

using example.Core;
using example.Units.Common;

namespace example.Units
{
    class Refinery: ABuilding, MFuelable, MFueler, MStorage, MAttackable
    {
        public Refinery(UInt32 initalTankValue): base("addr 3") {
            this.As<MFuelable>().InitTank(initalTankValue);
        }
    }
}
