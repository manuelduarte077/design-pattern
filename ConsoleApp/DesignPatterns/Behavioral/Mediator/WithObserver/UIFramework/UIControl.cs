namespace ConsoleApp.DesignPatterns.Behavioral.Mediator.WithObserver.UIFramework;

// This is our "Subject" from the GoF observer pattern.
public class UIControl
{
    private readonly List<EventHandler> _eventHandlers = new();

    public void AddEventHandler(EventHandler handler)
    {
        _eventHandlers.Add(handler);
    }

    public void NotifyEventHandlers()
    {
        foreach (var handler in _eventHandlers) handler();
    }
}