namespace ConsoleApp.DesignPatterns.Behavioral.Visitor.BadExample;

public class Restaurant : Client
{
    public Restaurant(string name, string email) : base(name, email)
    {
    }

    public override void SendEmail()
    {
        Console.WriteLine("Sending restaurant marketing tips email to " + _email);
    }
}