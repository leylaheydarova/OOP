namespace OOP.Models
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string FullName
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }

        public string FinCode
        {
            get
            {
                return "12T28YU";
            }
        }

        public string Pressure
        {
            set
            {
                Pressure = value;
            }
        }
    }
}
