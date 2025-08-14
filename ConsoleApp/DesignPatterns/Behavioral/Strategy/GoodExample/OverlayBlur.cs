namespace ConsoleApp.DesignPatterns.Behavioral.Strategy.GoodExample;

public class OverlayBlur : IOverlay
{
    public void Apply()
    {
        Console.WriteLine("Applying blur overlay");
    }
}