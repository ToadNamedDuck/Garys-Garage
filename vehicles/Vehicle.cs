namespace Gary_Garage
{
    public class Vehicle
    {
        public string MainColor { get; set; }

        public int MaximumOccupancy { get; set; }

        public virtual void Drive()
        {
            System.Console.WriteLine("Vrooom!");
        }

        public virtual void Stop()
        {
            System.Console.WriteLine("The vehicle carefully stops.");
        }

        public virtual void Turn(string Direction)
        {
            System.Console.WriteLine($"The vehicle carefully and skillfully turns {Direction}.");
        }

    }
}