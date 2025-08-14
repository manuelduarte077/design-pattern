namespace ConsoleApp.DesignPatterns.Structural.Composite.GoodExample;

public class Microphone : Item
{
    private readonly float _price = 29.99f;

    public float GetPrice()
    {
        return _price;
    }
}