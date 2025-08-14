namespace ConsoleApp.DesignPatterns.Behavioral.Strategy.GoodExample;

public class CompressorMOV : ICompressor
{
    public void Compress()
    {
        Console.WriteLine("Compressing video using MOV");
    }
}