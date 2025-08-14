namespace ConsoleApp.DesignPatterns.Creational.Prototype.BadExample;

public class Circle : Shape
{
    public int Radius { get; set; } = 5; // give a default radius of 5 for newly-created circles

    public void Draw()
    {
        Console.WriteLine("Drawing circle");
    }
}