namespace ConsoleApp.DesignPatterns.Creational.AbstractFactory.BadExample.Windows;

// /Windows/WindowsButton
public class WindowsButton : IButton
{
    public void Render()
    {
        Console.WriteLine("Windows: render button");
    }
}