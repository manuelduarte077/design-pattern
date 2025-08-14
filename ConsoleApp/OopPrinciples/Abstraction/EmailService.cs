namespace ConsoleApp.OopPrinciples.Abstraction;

internal class EmailService
{
    public void sendEmail()
    {
        Console.WriteLine("Sending email...");
    }

    // ALL THE BELOW METHODS ARE PRIVATE -- THEY ARE NOT EXPOSED TO OTHER CLASSES. OTHER CLASSES JUST WANT TO SEND EMAILS, NO NEED FOR THEM TO SEE ALL THE COMPLEX DETAILS OF CONNECTING TO MAIL SERVER, AUTHENTICATING, DISCONNECTING.

    private void connect()
    {
        Console.WriteLine("Connecting to email server...");
    }

    private void authenticate()
    {
        Console.WriteLine("Authenticating...");
    }

    private void disconnect()
    {
        Console.WriteLine("Disconnecting from email server...");
    }
}