namespace ConsoleApp.DesignPatterns.Creational.Prototype.BadExample;

public class Rectangle : Shape
{
    public int Width { get; set; } = 10;
    public int Height { get; set; } = 5;

    public void Draw()
    {
        Console.WriteLine("Drawing rectangle");
    }
}