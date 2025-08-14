namespace ConsoleApp.SOLID.D.BetterExample;

public class Car
{
    private readonly IEngine engine;

    public Car(IEngine engine)
    {
        this.engine = engine;
    }

    public void StartCar()
    {
        engine.Start();
        Console.WriteLine("Car started.");
    }
}