namespace ConsoleApp.SOLID.D.BadExample;

public class Car
{
    private readonly Engine engine;

    public Car()
    {
        engine = new Engine(); // Direct dependency on Engine class
    }

    public void StartCar()
    {
        engine.Start();
        Console.WriteLine("Car started.");
    }
}