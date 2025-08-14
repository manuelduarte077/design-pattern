namespace ConsoleApp.DesignPatterns.Structural.Facade.GoodExample;

public class Inventory
{
    public bool CheckInventory(string itemId)
    {
        return true; // just return true to keep example simple
    }

    public void ReduceInventory(string itemId, int amount)
    {
        Console.WriteLine("Reducing inventory of " + itemId + " by " + amount);
    }
}