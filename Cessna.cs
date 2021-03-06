using System;

namespace InheritanceIntro
{
    public class Cessna : Vehicle, IGasVehicle // Propellor light aircraft
    {
        public double FuelCapacity { get; set; }

        public void RefuelTank()
        {
            FuelCapacity = 100.0;
        }

        public override void Drive()
        {
            Console.WriteLine("The green Cessna drives past. Whoooooosh!");
        }

        public override void Turn(string direction)
        {
            Console.WriteLine($"The Cessna careens {direction}");
        }

        public override void Stop()
        {
            Console.WriteLine("The Cessna screeches to a halt after half a mile.");
        }

        public double CurrentTankPercentage()
        {
            return FuelCapacity;
        }
    }
}