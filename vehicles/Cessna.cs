namespace Gary_Garage
{
    public class Cessna : Vehicle
    {
        public double FuelCapacity {get; set;}

        public void RefuelTank()
        {
            System.Console.WriteLine($"The Cessna's fuel is topped off at {FuelCapacity} gallons.");
        }

        public override void Turn(string Direction)
        {
            System.Console.WriteLine($"The Cessna does a {Direction}-Oriented roll in the air.");
        }

        public override void Drive()
        {
            System.Console.WriteLine($"The {MainColor} Cessna takes off from the runway! It is flying in the air, and it is loud.");
        }

        public override void Stop()
        {
            System.Console.WriteLine($"The cessna rolls to a stop after a successful landing!");
        }
    }
}