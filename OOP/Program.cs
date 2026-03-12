using OOP;

FruitService service = new FruitService();
service.create("apple", 1);
service.create("banana", 2);
service.create("grape", 3);

service.getAll();
Console.WriteLine();
service.delete(2);

service.get(3);