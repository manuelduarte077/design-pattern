namespace ConsoleApp.DesignPatterns.Behavioral.Strategy.GoodExample;

public class OverlayBlackAndWhite : IOverlay
{
    public void Apply()
    {
        Console.WriteLine("Applying black and white overlay");
    }
}