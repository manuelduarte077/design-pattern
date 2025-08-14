namespace ConsoleApp.DesignPatterns.Structural.Decorator.OldBadExample;

public class FacebookNotifier : Notifier
{
    public override void Send(int userId, string message)
    {
        Console.WriteLine("Sending FB message to " + userId + " with message " + message);
        base.Send(userId, message);
    }
}