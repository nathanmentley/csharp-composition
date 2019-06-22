﻿using System;

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
            refinery.Fuel(truck, 3500);
            //the truck now has 3500 units and fills the empty gas station up 2000 units.
            truck.Fuel(station, 2000);
            //the car fills up from the gas station for 20 units. Leaving 1980 at the station.
            station.Fuel(car, 20);
            //the truck fuels the train 1500. Leaving the truck empty and the train at 1500 units.
            truck.Fuel(train, 1500);

            //print the current tank values.
            Console.WriteLine(
$@"tank values:
    The refinery has {refinery.GetTankValue()}.
    The semi has {truck.GetTankValue()}.
    The gas station has {station.GetTankValue()}.
    The car has {car.GetTankValue()}.
    The train has {train.GetTankValue()}."        
            );
        }
    }
}
