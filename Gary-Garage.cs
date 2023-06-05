using System;

namespace Gary_Garage
{
    class Program
    {
        static void Main(string[] args)
        {
            Tesla t = new Tesla();
            t.BatteryKWh = 65;
            t.MainColor = "Flaming-Hot Cheeto Red";
            t.ChargeBattery();
            t.Drive();
            t.Turn("Left");
            t.Stop();

            Ram r = new Ram();
            r.FuelCapacity = 800;
            r.MainColor = "Blue-Steel";
            r.RefuelTank();
            r.Drive();
            r.Turn("Right");
            r.Stop();

            Cessna c = new Cessna();
            c.FuelCapacity = 52;
            c.MainColor = "White";
            c.RefuelTank();
            c.Drive();
            c.Turn("Rightward");
            c.Stop();

            Zero z = new Zero();
            z.BatteryKWh = 58;
            z.MainColor = "Midnight-Black";
            z.ChargeBattery();
            z.Drive();
            z.Turn("Left");
            z.Stop();
        }
    }
}
