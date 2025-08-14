namespace ConsoleApp.DesignPatterns.Structural.Facade.BadExample;

public class OrderFulfillment
{
    private readonly Inventory _inventory;

    public OrderFulfillment(Inventory inventory)
    {
        _inventory = inventory;
    }

    public void Fulfill(string name, string address, string[] items)
    {
        Console.WriteLine("Inserting order into database");
        foreach (var item in items) _inventory.ReduceInventory(item, 1);
    }
}