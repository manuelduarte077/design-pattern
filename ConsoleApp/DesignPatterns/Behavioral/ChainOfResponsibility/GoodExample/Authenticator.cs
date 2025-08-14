namespace ConsoleApp.DesignPatterns.Behavioral.ChainOfResponsibility.GoodExample;

public class Authenticator : Handler
{
    public override bool DoHandle(HttpRequest request)
    {
        Console.WriteLine("Authenticating");
        var username = request.GetUsername();
        var password = request.GetPassword();
        return !(username == "danny" && password == "123");
    }
}