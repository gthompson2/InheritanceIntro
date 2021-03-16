using System;

namespace InheritanceIntro
{
    public class Zero : Vehicle, IElectricVehicle // Electric motorcycle
    {
        public double BatteryKWh { get; set; }
        public void ChargeBattery()
        {
            BatteryKWh = 100.00;
        }

        public override void Drive()
        {
            Console.WriteLine("The black Zero drives past. Zoooooom!");
        }
        public override void Turn(string direction)
        {
            Console.WriteLine($"The Zero turns {direction}");
        }

        public override void Stop()
        {
            Console.WriteLine("The Zero comes to a smooth stop.");
        }

        public double CurrentChargePercentage()
        {
            return BatteryKWh;
        }
    }
}