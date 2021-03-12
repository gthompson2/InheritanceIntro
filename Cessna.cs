using System;

namespace InheritanceIntro
{
    public class Cessna : Vehicle // Propellor light aircraft
    {
        public double FuelCapacity { get; set; }

        public void RefuelTank()
        {
            // method definition?
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
    }
}