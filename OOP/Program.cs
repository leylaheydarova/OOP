using OOP.Enums;

string[] week = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

var ar = Enum.GetValues(typeof(OOP.Enums.DayOfWeek));

foreach (var day in ar)
{
    //Console.WriteLine(day);
}
//enum dayofweek //obyekt
//{
//    Monday = 1,
//    Tuesday,
//    Wednesday,
//    Thursday,
//    Friday,
//    Saturday,
//    Sunday
//}

//var number = ((int)NumberPrefix.Germany);
//var country = NumberPrefix.Germany.ToString();

//Console.WriteLine($"{country} - {number}");

var countries = Enum.GetValues(typeof(NumberPrefix));
var countryNames = Enum.GetNames<NumberPrefix>();
//foreach (var country in countryNames)
//{
//    Console.WriteLine($"{country}");
//}

//Console.WriteLine(Enum.GetName(typeof(NumberPrefix), 994));

//Console.WriteLine(((int)NumberPrefix.Azerbaijan));

Console.WriteLine(Enum.IsDefined(typeof(NumberPrefix), "Iraq"));

