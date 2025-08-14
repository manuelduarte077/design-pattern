namespace ConsoleApp.DesignPatterns.Behavioral.ChainOfResponsibility.BadExample;

public class Validator
{
    public void Validate(HttpRequest request)
    {
        var username = request.GetUsername();
        var password = request.GetPassword();

        // Trim whitespace
        request.ValidatedUsername = username.Trim();
        request.ValidatedPassword = password.Trim();
    }
}