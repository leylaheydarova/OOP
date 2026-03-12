namespace OOP.Models
{
    public class Vehicle
    {
        public Vehicle()
        {
            Type = "Ship";
        }

        public Vehicle(string cabin)
        {
            Type = "Tir";
        }

        //public Vehicle(int passengerCount)
        //{
        //    Type = "plane";
        //}
        public Vehicle(int wheelCount)
        {
            WheelCount = wheelCount;
        }
        public string Name { get; set; }
        public double Weight { get; set; }
        public int WheelCount { get; set; }
        public string Type { get; set; }

        //public void Drive(string name)
        //{
        //    Console.WriteLine($"{name} is driving.");
        //}

        //public void Park()
        //{
        //    Console.WriteLine("Parking is done");
        //}
    }
}
