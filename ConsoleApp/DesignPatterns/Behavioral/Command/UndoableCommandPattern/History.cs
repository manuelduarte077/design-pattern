namespace ConsoleApp.DesignPatterns.Behavioral.Command.UndoableCommandPattern;

// Class to keep track of the commands that we've applied.
public class History
{
    private readonly List<UndoableCommand> commands = new();

    public void Push(UndoableCommand command)
    {
        commands.Add(command);
    }

    public UndoableCommand Pop()
    {
        var last = commands.Last();
        commands.Remove(last);
        return last;
    }

    public int Size()
    {
        return commands.Count;
    }
}