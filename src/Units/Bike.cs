using System;

using example.Core;
using example.Units.Common;

namespace example.Units
{
    class Bike: ATransport, MSteerable, MMovable, MAttackable
    {
        public Bike(): base("bike") {}
    }
}
