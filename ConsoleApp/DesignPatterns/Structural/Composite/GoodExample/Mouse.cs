namespace ConsoleApp.DesignPatterns.Structural.Composite.GoodExample;

public class Mouse : Item
{
    private readonly float _price = 18.00f;

    public float GetPrice()
    {
        return _price;
    }
}