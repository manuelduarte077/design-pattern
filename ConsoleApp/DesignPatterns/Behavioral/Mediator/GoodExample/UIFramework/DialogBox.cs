namespace ConsoleApp.DesignPatterns.Behavioral.Mediator.GoodExample.UIFramework;

// This class plays the role of "mediator". Every time a UI component changes state, it'll call its group's
//  dialogue box.
// Abstract class, not interface, because a real GUI framework would provide some concrete methods too
public abstract class DialogBox
{
    public abstract void Changed(UIControl uiControl);
}