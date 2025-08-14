namespace ConsoleApp.DesignPatterns.Behavioral.Mediator.GoodExample.UIFramework;

public abstract class UIControl
{
    protected DialogBox
        _owner; // so all UI components can be grouped into a dialogue box and know & can talk to their owner, allowing the owner to change other UI components accordingly

    public UIControl(DialogBox owner)
    {
        _owner = owner;
    }
}