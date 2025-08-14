namespace ConsoleApp.DesignPatterns.Structural.Decorator.OldBadExample;

public class SMSNotifier : Notifier
{
    public override void Send(int userId, string message)
    {
        Console.WriteLine("Sending SMS to " + userId + " with message " + message);
        base.Send(userId, message);
    }
}