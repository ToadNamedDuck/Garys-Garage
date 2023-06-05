namespace Gary_Garage
{
    public class Tesla: Vehicle
    {
        public double BatteryKWh { get; set; }

        public void ChargeBattery()
        {
            System.Console.WriteLine("Tesla's battery is charged!");
        }

        public override void Drive()
        {
            System.Console.WriteLine($"The {MainColor} Tesla moves in silence like the 'g' in lasagna.");
        }

        public override void Stop()
        {
            System.Console.WriteLine("The Tesla stops on a time, like all life on Earth depended on it.");
        }
    }
}