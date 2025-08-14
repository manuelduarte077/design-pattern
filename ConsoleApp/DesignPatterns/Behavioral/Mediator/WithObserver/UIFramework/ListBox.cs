namespace ConsoleApp.DesignPatterns.Behavioral.Mediator.WithObserver.UIFramework;

public class ListBox : UIControl
{
    private string _selection = "";

    public string GetSelection()
    {
        return _selection;
    }

    public void SetSelection(string selection)
    {
        _selection = selection;
        NotifyEventHandlers();
    }
}