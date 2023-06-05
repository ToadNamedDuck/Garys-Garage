namespace Gary_Garage
{
    public class Zero: Vehicle
    {
        public double BatteryKWh { get; set; }

        public void ChargeBattery()
        {
            System.Console.WriteLine("The Zero's battery is charged!");
        }

        public override void Drive()
        {
            System.Console.WriteLine($"The {MainColor} Zero zooms past you.");
        }
    }
}