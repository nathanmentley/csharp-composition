using System;

using example.Core;
using example.Units.Common;

namespace example.Units
{
    class Refinery: ABuilding, MFuelable, MFueler, MStorage
    {
        public Refinery(UInt32 initalTankValue): base("817 SE 15th Portland Or 97214") {
            this.InitTank(initalTankValue);
        }
    }
}
