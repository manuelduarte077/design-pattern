namespace ConsoleApp.DesignPatterns.Creational.AbstractFactory.GoodExample.Windows;

public class WindowsButton : IButton
{
    public void Render()
    {
        Console.WriteLine("Windows: render button");
    }
}