namespace OOP.Models
{
    public class Bus : Auto
    {
        public string Model { get; set; }
        public Bus() : base(4)
        {
        }
        //public override void Drive()
        //{
        //    Console.WriteLine("Bus is driving.");
        //}
    }
}
