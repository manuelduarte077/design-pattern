namespace ConsoleApp.OopPrinciples.Polymorphism.BadExample;

public class Car
{
    public string Brand { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }

    public int NumberOfDoors { get; set; }

    public void Start()
    {
        Console.WriteLine("Car is starting.");
    }

    public void Stop()
    {
        Console.WriteLine("Car is stopping.");
    }
}