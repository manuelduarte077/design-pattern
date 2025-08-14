namespace ConsoleApp.DesignPatterns.Behavioral.Mediator.GoodExample.UIFramework;

public class ListBox : UIControl
{
    private string _selection = "";

    public ListBox(DialogBox owner) : base(owner)
    {
    }

    public string GetSelection()
    {
        return _selection;
    }

    public void SetSelection(string selection)
    {
        _selection = selection;
        _owner.Changed(this);
    }
}