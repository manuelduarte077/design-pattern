namespace ConsoleApp.DesignPatterns.Behavioral.Visitor.BadExample;

public class Retail : Client
{
    public Retail(string name, string email) : base(name, email)
    {
    }

    public override void SendEmail()
    {
        Console.WriteLine("Sending retail marketing tips email to " + _email);
    }
}