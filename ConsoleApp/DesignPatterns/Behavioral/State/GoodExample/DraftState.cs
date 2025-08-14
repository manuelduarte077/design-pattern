namespace ConsoleApp.DesignPatterns.Behavioral.State.GoodExample;

public class DraftState : State
{
    private readonly Document _document;

    public DraftState(Document document)
    {
        _document = document;
    }

    public void Publish()
    {
        _document.State = new ModerationState(_document);
    }
}