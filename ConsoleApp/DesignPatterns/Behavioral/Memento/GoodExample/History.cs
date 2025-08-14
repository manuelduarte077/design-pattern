namespace ConsoleApp.DesignPatterns.Behavioral.Memento.GoodExample;

// Caretaker
public class History
{
    private readonly Editor _editor;
    private readonly List<EditorState> _states = new();

    public History(Editor editor)
    {
        _editor = editor;
    }

    public void Backup()
    {
        _states.Add(_editor.CreateState());
    }

    public void Undo()
    {
        if (_states.Count == 0) return;

        var prevState = _states.Last();
        _states.Remove(prevState);

        _editor.Restore(prevState);
    }

    public void ShowHistory()
    {
        Console.WriteLine("\nHistory: Here's the list of mementos:");

        foreach (var state in _states) Console.WriteLine(state.GetName());
    }
}