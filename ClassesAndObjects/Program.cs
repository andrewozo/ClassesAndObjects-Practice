// See https://aka.ms/new-console-template for more information

using ClassesAndObjects;




Car audi = new Car("Audi A4",320);
audi.Details();

audi.Drive();

Console.WriteLine("Press 1 to stop the car");
string? userInput = Console.ReadLine();

if (userInput == "1")
{
    audi.Stop();
}
