namespace ConsoleApp.DesignPatterns.Behavioral.ChainOfResponsibility.GoodExample;

public class Logger : Handler
{
    public override bool DoHandle(HttpRequest request)
    {
        Console.WriteLine("Logging");
        return false;
    }
}