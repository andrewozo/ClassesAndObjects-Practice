// See https://aka.ms/new-console-template for more information

using ClassesAndObjects;




Car audi = new Car("audi");

audi.Drive();

Console.WriteLine("Press 1 to stop the car");
string? userInput = Console.ReadLine();

if (userInput == "1")
{
    audi.Stop();
}
