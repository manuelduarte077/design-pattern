namespace ConsoleApp.DesignPatterns.Behavioral.Memento.BadExample;

public class Editor
{
    private readonly List<string> _prevContents = new();
    private readonly List<string> _prevTitles = new();

    private string _content = "";

    private string _title = "";


    public string GetContent()
    {
        return _content;
    }

    public void SetContent(string content)
    {
        _prevContents.Add(_content);
        _content = content;
    }

    public string GetTitle()
    {
        return _title;
    }

    public void SetTitle(string title)
    {
        _prevTitles.Add(_title);
        _title = title;
    }

    public void Undo()
    {
        UndoContent();
        UndoTitle();
    }

    public void UndoContent()
    {
        var lastContent = _prevContents.Last();
        _prevContents.Remove(lastContent);
        _content = lastContent;
    }

    public void UndoTitle()
    {
        var lastTitle = _prevTitles.Last();
        _prevTitles.Remove(lastTitle);
        _title = lastTitle;
    }
}