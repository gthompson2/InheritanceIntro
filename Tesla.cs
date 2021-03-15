using System;

namespace InheritanceIntro
{
    public class Tesla : Vehicle // Electric Car
    {
        public double BatteryKWh { get; set; }

        public void ChargeBattery()
        {
            // method?
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
    }
}