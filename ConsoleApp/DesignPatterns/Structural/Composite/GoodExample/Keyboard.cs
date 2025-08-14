namespace ConsoleApp.DesignPatterns.Structural.Composite.GoodExample;

public class Keyboard : Item
{
    private readonly float _price = 40.00f;

    public float GetPrice()
    {
        return _price;
    }
}