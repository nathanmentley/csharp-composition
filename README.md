# C# Compostion Pattern Example.

We have these types.

    Bike,
    Car,
    FuelSemiTruck,
    GasStation,
    House,
    Train

Some are Buildings, some are transports.

Some can be steered, some can use fuel and be filled up. Some can fuel up things that need fuel.

Since all of these types are either buildings or transports. We can view that as an "IS A" relationship. So I setup base Abstract classes for them to inherit.

ABuilding, ATransport.

However, since some buildings can be fueled, and can fuel.... and since some cars can be fueled and can fuel. It would be silly to copy and paste that code. and create a base class for each possibly combination.
So instead we can use mixins and compose what we actually want.

MFuelable, MFueler, and MSteerable are all interfaces, that because of convention I'm prefixing with M. And then building extension methods off of them to set them up as mixins.

This way, a GasStation can be a building, that is MFueler, and MFuelable.
A house can be a building that is neither.

A Train can take fuel, and be a transport. but doesn't have steering logic.
A Car, can be a vehical, that is fueled, and can be steered.
A SemiTruckGasTanker, can be a vehical that is fueled, and can fuel other things, and be steered.

Because we're using mixins and composition we're keeping code duplication to a minimum.

All composible types need to implemnt IComposble to give an interface for our Composing Mixins to securely store and get data.
See ComposableObject for an example on how to implement this. Feel free to inherit from it and just use that prebuild implementation.

For our composable mixins we do this:

```
using System;

using example.Core;

namespace example.Units.Common
{
    public interface MFueler: MFuelable, IComposable {}
    static public class MFuelerEx {
        public static void Fuel(this MFueler supply, MFuelable fuelableEntity, UInt32 amount = 20) {
            for(UInt32 i = 0; i < amount; i++) {
                if(!fuelableEntity.IsTankFull() && !supply.IsTankEmpty()) {
                    fuelableEntity.IncrementTank();
                    supply.DecrementTank();
                } else {
                    //throw different exceptions for different siturations... instead of a vague invalid op exception.
                    throw new InvalidOperationException($"Fueler tank is either empty, or tank to be fueled is full.");
                }
            }
        }
    }
}
```

Where we have an interface that we then add extension methods off of. This is valid modern C#. In C# 8 we'll be able to add default bodys to interfaces, so the extensiosn aren't needed.
