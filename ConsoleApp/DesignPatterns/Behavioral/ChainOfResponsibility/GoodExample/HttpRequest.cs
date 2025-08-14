namespace ConsoleApp.DesignPatterns.Behavioral.ChainOfResponsibility.GoodExample;

public class HttpRequest
{
    private readonly string _password;
    private readonly string _username;


    public HttpRequest(string username, string password)
    {
        _username = username;
        _password = password;
    }

    public string ValidatedUsername { get; set; } = "";
    public string ValidatedPassword { get; set; } = "";

    public string GetUsername()
    {
        return _username;
    }

    public string GetPassword()
    {
        return _password;
    }
}