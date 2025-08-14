namespace ConsoleApp.DesignPatterns.Behavioral.Visitor.GoodExample;

public abstract class Client
{
    protected string _email;
    protected string _name;

    public Client(string name, string email)
    {
        _name = name;
        _email = email;
    }

    public string GetEmail()
    {
        return _email;
    }

    public abstract void Accept(Visitor visitor);
}