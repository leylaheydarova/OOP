namespace OOP.Models
{
    public sealed class Car : Auto
    {
        public string Motor { get; set; }
        public Car() : base(4)
        {
        }
        //public override void Drive()
        //{
        //    Console.WriteLine("Car is driving");
        //}
    }
}
