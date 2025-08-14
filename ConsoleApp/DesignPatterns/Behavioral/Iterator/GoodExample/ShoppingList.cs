namespace ConsoleApp.DesignPatterns.Behavioral.Iterator.GoodExample;

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

    public IIterator<string> CreateIterator()
    {
        return new ListIterator(this);
    }

    private class ListIterator : IIterator<string>
    {
        private readonly ShoppingList _shoppingList;
        private int _index;

        public ListIterator(ShoppingList shoppingList)
        {
            _shoppingList = shoppingList;
        }

        public string Current()
        {
            return _shoppingList._list[_index];
        }

        public void Next()
        {
            _index++;
        }

        public bool HasNext()
        {
            return _index < _shoppingList._list.Count;
        }
    }
}