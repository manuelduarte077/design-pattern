namespace ConsoleApp.DesignPatterns.Creational.AbstractFactory.GoodExample.Windows;

public class WindowsCheckbox : ICheckbox
{
    public void Render()
    {
        Console.WriteLine("Windows: render checkbox");
    }
}