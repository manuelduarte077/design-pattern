namespace ConsoleApp.DesignPatterns.Creational.Prototype.GoodExample;

public class Rectangle : Shape
{
    public int Width { get; set; } = 10;
    public int Height { get; set; } = 5;

    public void Draw()
    {
        Console.WriteLine("Drawing rectangle");
    }

    public Shape Duplicate()
    {
        var newRectangle = new Rectangle();
        newRectangle.Width = Width;
        newRectangle.Height = Height;
        return newRectangle;
    }
}