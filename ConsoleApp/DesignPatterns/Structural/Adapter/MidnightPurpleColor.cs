namespace ConsoleApp.DesignPatterns.Structural.Adapter;

public class MidnightColor : Color
{
    public void Apply(Video video)
    {
        Console.WriteLine("Applying midnight-purple color to video");
        ;
    }
}