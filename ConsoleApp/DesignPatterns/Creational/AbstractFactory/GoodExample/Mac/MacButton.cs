namespace ConsoleApp.DesignPatterns.Creational.AbstractFactory.GoodExample.Mac;

public class MacButton : IButton
{
    public void Render()
    {
        Console.WriteLine("Mac: render button");
    }
}