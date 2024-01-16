// See https://aka.ms/new-console-template for more information

using ClassesAndObjects;




Car myCar = new Car();
Console.WriteLine(myCar.Name);
myCar.Name = "Audi A3";
myCar.Details();
myCar.MaxSpeed = 180;
Console.WriteLine(myCar.MaxSpeed);

