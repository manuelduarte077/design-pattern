namespace ConsoleApp.DesignPatterns.Behavioral.State.GoodExample;

public class Document
{
    public Document(UserRoles currentUserRole)
    {
        State = new DraftState(this); // New documents have draft state by default
        CurrentUserRole = currentUserRole;
    }

    public State State { get; set; }
    public UserRoles CurrentUserRole { get; set; }

    public void Publish()
    {
        State.Publish();
    }
}