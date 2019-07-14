using System;

using example.Core;
using example.Units;
using example.Units.Common;

namespace example
{
    class Program
    {
        static void Main(string[] args)
        {
            //setup our entities.
            // Everything but the refinery starts empty. The refinery is seeded with 1 million units.
            Refinery refinery = new Refinery(1_000_000);
            FuelSemiTruck truck = new FuelSemiTruck();
            GasStation station = new GasStation();
            Car car = new Car();
            Train train = new Train();
            
            //the refinery starts with a million units and fills the semi up with 3500 units.
            refinery.AsComp<MFueler>().Fuel(truck, 3500);
            //the truck now has 3500 units and fills the empty gas station up 2000 units.
            truck.AsComp<MFueler>().Fuel(station, 2000);
            //the car fills up from the gas station for 20 units. Leaving 1980 at the station.
            station.AsComp<MFueler>().Fuel(car, 20);
            //the truck fuels the train 1500. Leaving the truck empty and the train at 1500 units.
            truck.AsComp<MFueler>().Fuel(train, 1500);

            //print the current tank values.
            Console.WriteLine(
$@"tank values:
    The refinery has {refinery.AsComp<MFuelable>().GetTankValue()}.
    The semi has {truck.AsComp<MFuelable>().GetTankValue()}.
    The gas station has {station.AsComp<MFuelable>().GetTankValue()}.
    The car has {car.AsComp<MFuelable>().GetTankValue()}.
    The train has {train.AsComp<MFuelable>().GetTankValue()}."        
            );
        }
    }
}
