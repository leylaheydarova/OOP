namespace OOP.Models
{
    //static properties
    public partial class Person
    {
        public static string SerialNumber { get; set; } = "AA234433";

    }

    //Non-static properties
    public partial class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
    }

    //readonly properties
    public partial class Person
    {
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
