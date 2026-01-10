using OOP.Models;

Vehicle ship = new Vehicle();
ship.Name = "Mubariz Ibrahimov";
ship.Weight = 35;
ship.WheelCount = 0;

Vehicle plane = new Vehicle(400);
plane.Name = "AK372";
plane.Weight = 50;
plane.WheelCount = 3;

Vehicle tir = new Vehicle("sport things");
tir.Name = "KAMAZ123";
tir.Weight = 10;
tir.WheelCount = 16;