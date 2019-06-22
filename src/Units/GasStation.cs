using System;

using example.Core;
using example.Units.Common;

namespace example.Units
{
    class GasStation: ABuilding, MFuelable, MFueler, MStorage
    {
        public GasStation(): base("923 W Cross Ypsilanti Mi 48197") {}
    }
}
