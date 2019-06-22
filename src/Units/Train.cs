using System;

using example.Core;
using example.Units.Common;

namespace example.Units
{
    class Train: ATransport, MFuelable, MMovable, MStorage
    {
        public Train(): base("train") {}
    }
}
