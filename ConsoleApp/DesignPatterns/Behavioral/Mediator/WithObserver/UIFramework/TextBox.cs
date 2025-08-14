namespace ConsoleApp.DesignPatterns.Behavioral.Mediator.WithObserver.UIFramework;

public class TextBox : UIControl
{
    private string _text = "";

    public string GetText()
    {
        return _text;
    }

    public void SetText(string text)
    {
        _text = text;
        NotifyEventHandlers();
    }
}