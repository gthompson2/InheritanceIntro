using System;

namespace InheritanceIntro
{
    public interface IGasVehicle
    {
        double CurrentTankPercentage();
        void RefuelTank(); // Charges vehicle to 100%
    }
}