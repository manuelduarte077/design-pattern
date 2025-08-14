namespace ConsoleApp.DesignPatterns.Creational.AbstractFactory.BadExample.Mac;

// Mac/MacButton
public class MacButton : IButton
{
    public void Render()
    {
        Console.WriteLine("Mac: render button");
    }
}