namespace ConsoleApp.SOLID.D.BetterExample;

public class Engine : IEngine // our "low-level" module
{
    public void Start()
    {
        Console.WriteLine("Engine started.");
    }
}