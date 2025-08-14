namespace ConsoleApp.DesignPatterns.Behavioral.ChainOfResponsibility.GoodExample;

public class Validator : Handler
{
    public override bool DoHandle(HttpRequest request)
    {
        Console.WriteLine("Validating");
        var username = request.GetUsername();
        var password = request.GetPassword();

        // Trim whitespace
        request.ValidatedUsername = username.Trim();
        request.ValidatedPassword = password.Trim();

        // returning false means that we are not done processing the request, so the next handler in the chain should be called. Returning true ends the request processing here.
        return request.ValidatedUsername == "" || request.ValidatedPassword == "";
    }
}