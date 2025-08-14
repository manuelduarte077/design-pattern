namespace ConsoleApp.DesignPatterns.Behavioral.ChainOfResponsibility.BadExample;

public class Authenticator
{
    public bool Authenticate(HttpRequest request)
    {
        var username = request.GetUsername();
        var password = request.GetPassword();

        return username == "danny" && password == "123";
    }
}