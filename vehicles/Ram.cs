namespace Gary_Garage
{
    public class Ram : Vehicle
    {
        public double FuelCapacity {get; set;}

        public void RefuelTank()
        {
            System.Console.WriteLine($"The Ram's tank is topped off to {FuelCapacity} gallons.");
        }

        public override void Drive()
        {
            System.Console.WriteLine($"And the fifth rider drove a {MainColor} Ram, and black smoke followed in his wake, and his enemies were blinded by his divine retribution headlights.");
        }

        public override void Stop()
        {
            System.Console.WriteLine("The Ram does not stop, nor will it ever stop.");
        }
    }
}