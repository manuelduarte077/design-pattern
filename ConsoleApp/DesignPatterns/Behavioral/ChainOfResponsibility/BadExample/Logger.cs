namespace ConsoleApp.DesignPatterns.Behavioral.ChainOfResponsibility.BadExample;

public class Logger
{
    public void Log(HttpRequest request)
    {
        Console.WriteLine("Log");
    }
}