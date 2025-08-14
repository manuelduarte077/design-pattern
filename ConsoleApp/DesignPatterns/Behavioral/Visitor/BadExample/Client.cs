namespace ConsoleApp.DesignPatterns.Behavioral.Visitor.BadExample;

public abstract class Client
{
    protected string _email;
    protected string _name;

    public Client(string name, string email)
    {
        _name = name;
        _email = email;
    }

    public abstract void SendEmail();
}