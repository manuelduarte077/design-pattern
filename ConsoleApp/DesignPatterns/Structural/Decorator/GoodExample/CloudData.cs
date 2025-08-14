namespace ConsoleApp.DesignPatterns.Structural.Decorator.GoodExample;

public class CloudData : Data
{
    private readonly string _url;

    public CloudData(string url)
    {
        _url = url;
    }

    public void Save(string data)
    {
        Console.WriteLine($"Saving data '{data}' to cloud at '{_url}'");
    }
}