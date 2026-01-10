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

        public Vehicle(int passengerCount)
        {
            Type = "plane";
        }
        public string Name { get; set; }
        public double Weight { get; set; }
        public int WheelCount { get; set; }
        public string Type { get; set; }
    }
}
