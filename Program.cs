using System;

namespace InheritanceIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Zero fxs = new Zero();
            Tesla modelS = new Tesla();
            Cessna mx410 = new Cessna();

            fxs.Drive();
            fxs.Turn("left");
            fxs.Stop();

            modelS.Drive();
            modelS.Turn("right");
            modelS.Stop();

            mx410.Drive();
            mx410.Turn("left");
            mx410.Stop();
        }
    }
}
