namespace ConsoleApp.DesignPatterns.Behavioral.Visitor.BadExample;

public class Law : Client
{
    public Law(string name, string email) : base(name, email)
    {
    }

    public override void SendEmail()
    {
        Console.WriteLine("Sending law marketing tips email to " + _email);
    }
}