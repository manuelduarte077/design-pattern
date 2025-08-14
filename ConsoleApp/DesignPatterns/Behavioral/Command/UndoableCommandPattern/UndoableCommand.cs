namespace ConsoleApp.DesignPatterns.Behavioral.Command.UndoableCommandPattern;

// UndoableCommand extends Command, so every UndoableCommand object is a Command object.
public interface UndoableCommand : Command
{
    void Unexecute();
}