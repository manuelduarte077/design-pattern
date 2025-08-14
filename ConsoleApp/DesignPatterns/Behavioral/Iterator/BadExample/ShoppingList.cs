namespace ConsoleApp.DesignPatterns.Behavioral.Iterator.BadExample;

public class ShoppingList
{
    private readonly List<string> _list = new();


    public void Push(string itemName)
    {
        _list.Add(itemName);
    }

    public string Pop()
    {
        var last = _list.Last();
        _list.Remove(last);
        return last;
    }

    public List<string> GetList()
    {
        return _list;
    }
}