namespace ConsoleApp.DesignPatterns.Structural.Composite.GoodExample;

public class Box : Item
{
    private readonly List<Item> items = new();

    public float GetPrice()
    {
        var total = 0f;
        foreach (var item in items) total += item.GetPrice();
        return total;
    }

    public void Add(Item item)
    {
        items.Add(item);
    }
}