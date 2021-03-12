using System;

namespace InheritanceIntro
{
    public class Vehicle // Parent class 
    {
        public string MainColor { get; set; }
        public string MaximumOccupancy { get; set; }
        public virtual void Drive()
        {
            Console.WriteLine("Vrooom!");
        }
    }
}