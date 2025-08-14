namespace ConsoleApp.DesignPatterns.Creational.AbstractFactory.GoodExample.Mac;

// /Mac/MacUIComponentFactory.cs
public class MacUIComponentFactory : IUIComponentFactory
{
    public IButton CreateButton()
    {
        return new MacButton();
    }

    public ICheckbox CreateCheckbox()
    {
        return new MacCheckbox();
    }
}