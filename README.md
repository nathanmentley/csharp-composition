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
The biggest excepion here, is since we can have extension properties, some of the mixins define properties on the interface. This has the sideaffect that we'd need to both duplicate that definition and we also expsoe that property to code that doesn't need it and shouldn't see it... since it'll need to be public.
