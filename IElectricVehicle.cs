using System;

namespace InheritanceIntro
{
    public interface IElectricVehicle
    {
        double CurrentChargePercentage();
        void ChargeBattery(); // Charges vehicle to 100%
    }
}