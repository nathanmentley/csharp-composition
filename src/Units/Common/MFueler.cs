using System;

using example.Core;

namespace example.Units.Common
{
    public interface MFueler: MFuelable, MComposable
    {
        public void Fuel(MFuelable fuelableEntity, UInt32 amount = 20)
        {
            for(UInt32 i = 0; i < amount; i++)
            {
                if(!fuelableEntity.IsTankFull() && !IsTankEmpty())
                {
                    fuelableEntity.IncrementTank();
                    DecrementTank();
                }
                else
                {
                    //throw different exceptions for different siturations... instead of a vague invalid op exception.
                    throw new InvalidOperationException($"Fueler tank is either empty, or tank to be fueled is full.");
                }
            }
        }
    }
}

