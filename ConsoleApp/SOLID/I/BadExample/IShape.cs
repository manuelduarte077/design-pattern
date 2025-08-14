namespace ConsoleApp.SOLID.I.BadExample;

public interface IShape
{
    double Area();
    double Volume(); // problem: 2D shapes don't have volume
}