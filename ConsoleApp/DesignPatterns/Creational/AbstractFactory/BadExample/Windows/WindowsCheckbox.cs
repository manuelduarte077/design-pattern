namespace ConsoleApp.DesignPatterns.Creational.AbstractFactory.BadExample.Windows;

// Windows/WindowsCheckbox
public class WindowsCheckbox : ICheckbox
{
    public void Render()
    {
        Console.WriteLine("Windows: render checkbox");
    }
}