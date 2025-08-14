namespace ConsoleApp.DesignPatterns.Creational.Prototype.GoodExample;

public class ShapeActions
{
    public Shape Duplicate(Shape shape)
    {
        Console.WriteLine("Duplicating shape");
        return shape.Duplicate();
    }
}