namespace ConsoleApp.OopPrinciples.Composition;

public class Car
{
    private readonly Chassis chassis = new();
    private readonly Engine engine = new();
    private readonly Seats seats = new();
    private readonly Wheels wheels = new();


    public void StartCar()
    {
        engine.Start();
        wheels.Rotate();
        chassis.Support();
        seats.Sit();
        Console.WriteLine("Car started");
    }
}