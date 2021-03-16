using System;

namespace InheritanceIntro
{
    public class Ram : Vehicle, IGasVehicle
    {
        public double FuelCapacity { get; set; }

        public void RefuelTank()
        {
            FuelCapacity = 100.0;
        }

        public override void Drive()
        {
            Console.WriteLine("The Silver Ram drives past. Ruuuuuuuuummmmmm!");
        }

        public override void Turn(string direction)
        {
            Console.WriteLine($"The Ram careens {direction}");
        }

        public override void Stop()
        {
            Console.WriteLine("The Ram Grinds to a halt.");
        }

        public double CurrentTankPercentage()
        {
            return FuelCapacity;
        }


    }
}