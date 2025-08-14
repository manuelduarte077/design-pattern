namespace ConsoleApp.DesignPatterns.Behavioral.Strategy.GoodExample;

public class OverlayNone : IOverlay
{
    public void Apply()
    {
        Console.WriteLine("Not applying an overlay");
    }
}