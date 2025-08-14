namespace ConsoleApp.DesignPatterns.Creational.AbstractFactory.GoodExample;

public interface IUIComponentFactory
{
    IButton CreateButton();
    ICheckbox CreateCheckbox();
}