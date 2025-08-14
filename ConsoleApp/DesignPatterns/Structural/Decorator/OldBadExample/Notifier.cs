namespace ConsoleApp.DesignPatterns.Structural.Decorator.OldBadExample;

public class Notifier
{
    public virtual void Send(int userId, string message)
    {
        Console.WriteLine("Sending email to " + userId + " with message " + message);
    }
}