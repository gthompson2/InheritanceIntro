using System;

namespace InheritanceIntro
{
    public class Tesla : Vehicle, IElectricVehicle // Electric Car
    {
        public double BatteryKWh { get; set; }

        public void ChargeBattery()
        {
            BatteryKWh = 100.00;
        }

        public override void Drive()
        {
            Console.WriteLine("The red Tesla floats past. In a rocket. Headed to Mars.");
        }

        public override void Turn(string direction)
        {
            Console.WriteLine($"The Tesla floats {direction}");
        }

        public override void Stop()
        {
            Console.WriteLine("We can't stop, we're floating in space!");
        }
        public double CurrentChargePercentage()
        {
            return BatteryKWh;
        }
    }
}