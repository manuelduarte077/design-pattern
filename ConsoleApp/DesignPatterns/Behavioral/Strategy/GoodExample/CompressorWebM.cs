namespace ConsoleApp.DesignPatterns.Behavioral.Strategy.GoodExample;

public class CompressorWebM : ICompressor
{
    public void Compress()
    {
        Console.WriteLine("Compressing video using WebM");
    }
}