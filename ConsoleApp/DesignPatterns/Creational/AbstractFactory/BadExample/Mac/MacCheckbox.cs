namespace ConsoleApp.DesignPatterns.Creational.AbstractFactory.BadExample.Mac;

// /Mac/MacCheckbox.cs
public class MacCheckbox : ICheckbox
{
    public void Render()
    {
        Console.WriteLine("Mac: render checkbox");
    }
}