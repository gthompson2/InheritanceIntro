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
            Console.WriteLine("Zoooooom!");
        }
    }
}