using OOP.Interfaces;

namespace OOP.Models
{
    public class Auto : Vehicle, IAutoService, IVehicleService
    {
        public Guid Id { get; set; }
        public double Price { get; set; }
        public int Speed { get; set; }
        public decimal SuretlerQutusu { get; set; }
        public bool IsAutomated { get; set; }
        public string Brand { get; set; }
        public Auto(int wheelCount) : base(wheelCount)
        {
        }

        public void Sell()
        {
            Console.WriteLine("Auto is sold");
        }

        public void Drive(string name)
        {
            Console.WriteLine("Bus is driving");
        }

        public void Park()
        {
            Console.WriteLine("Bus is parked.");
        }
    }
}
