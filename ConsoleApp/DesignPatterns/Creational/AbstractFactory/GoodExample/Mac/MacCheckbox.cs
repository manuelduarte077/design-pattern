namespace ConsoleApp.DesignPatterns.Creational.AbstractFactory.GoodExample.Mac;

public class MacCheckbox : ICheckbox
{
    public void Render()
    {
        Console.WriteLine("Mac: render checkbox");
    }
}