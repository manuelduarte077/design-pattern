namespace ConsoleApp.DesignPatterns.Behavioral.Strategy.GoodExample;

public class CompressorMP4 : ICompressor
{
    public void Compress()
    {
        Console.WriteLine("Compressing video using MP4");
    }
}