namespace ConsoleApp.SOLID.S.BadExample;

public class User
{
    public string Username { get; set; }
    public string Email { get; set; }

    public void Register()
    {
        // Register user logic
        // ...

        // Send email notification
        var emailSender = new EmailSender();
        emailSender.SendEmail("Welcome to our platform!", Email);
    }
}