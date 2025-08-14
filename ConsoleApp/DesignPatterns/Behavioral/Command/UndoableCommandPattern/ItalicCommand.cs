namespace ConsoleApp.DesignPatterns.Behavioral.Command.UndoableCommandPattern;

public class ItalicCommand : UndoableCommand
{
    private readonly HtmlDocument _doc;
    private readonly History _history;
    private string _prevContent = "";

    public ItalicCommand(HtmlDocument doc, History history)
    {
        _doc = doc;
        _history = history;
    }

    public void Execute()
    {
        _prevContent = _doc.Content;
        _doc.MakeItalic(); // delegate the work to the doc business object
        _history.Push(this);
    }

    public void Unexecute()
    {
        _doc.Content = _prevContent;
    }
}