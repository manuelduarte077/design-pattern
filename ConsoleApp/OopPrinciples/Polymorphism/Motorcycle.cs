namespace ConsoleApp.OopPrinciples.Polymorphism;

public class Motorcycle : Vehicle
{
    public override void Start()
    {
        Console.WriteLine("Motorcycle is starting.");
    }

    public override void Stop()
    {
        Console.WriteLine("Motorcycle is stopping.");
    }
}