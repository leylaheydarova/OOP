using OOP;
using System.Text.Json;

//var apple = new Fruit()
//{
//    Id = 1,
//    Name = "Apple"
//};

//var peach = new Fruit()
//{
//    Id = 2,
//    Name = "Peach"
//};

//var grape = new Fruit()
//{
//    Id = 3,
//    Name = "Grape"
//};

//var pineapple = new Fruit()
//{
//    Id = 4,
//    Name = "Pineapple"
//};

//Fruit[] fruits = { apple, peach, grape, pineapple, apple, gr };
//var file = File.Open(@"D:\Programming\Teaching\CodeLank\Practices\C#-02\OOP\OOP\fruits.txt", FileMode.OpenOrCreate);
//JsonSerializer.Serialize(file, fruits);
//file.Close();





var file = File.OpenRead(@"D:\Programming\Teaching\CodeLank\Practices\C#-02\OOP\OOP\fruits.txt");
var fruits = JsonSerializer.Deserialize<Fruit[]>(file);
file.Close();
foreach (var fruit in fruits)
{
    Console.WriteLine($"{fruit.Id} {fruit.Name}");
}