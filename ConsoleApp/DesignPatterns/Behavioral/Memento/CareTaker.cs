namespace ConsoleApp.DesignPatterns.Behavioral.Memento;

public class CareTaker
{
    private readonly List<IMemento> _mementos = new();

    private readonly Originator _originator;

    public CareTaker(Originator originator)
    {
        _originator = originator;
    }

    public void Backup()
    {
        Console.WriteLine("\nCaretaker: Saving Originator's state...");
        _mementos.Add(_originator.Save());
    }

    public void Undo()
    {
        if (_mementos.Count == 0) return;

        var memento = _mementos.Last();
        _mementos.Remove(memento);

        Console.WriteLine("Caretaker: Restoring state to: " + memento.GetName());

        try
        {
            _originator.Restore(memento);
        }
        catch (Exception)
        {
            Undo();
        }
    }


    public void ShowHistory()
    {
        Console.WriteLine("\nCaretaker: Here's the list of mementos:");

        foreach (var memento in _mementos) Console.WriteLine(memento.GetName());
    }
}