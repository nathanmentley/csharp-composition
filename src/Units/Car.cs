using System;

using example.Core;
using example.Units.Common;

namespace example.Units
{
    class Car: ATransport, MSteerable, MFuelable, MMovable, MStorage
    {
        public Car(): base("car") {}
    }
}
