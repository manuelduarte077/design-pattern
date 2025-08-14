namespace ConsoleApp.DesignPatterns.Behavioral.Observer.GoodExample;

public class Subject
{
    private readonly List<Observer> _observers = new();

    public void AddObserver(Observer observer)
    {
        _observers.Add(observer);
    }

    public void RemoveObserver(Observer observer)
    {
        _observers.Remove(observer);
    }

    public void NotifyObservers()
    {
        foreach (var observer in _observers) observer.Update();
    }
}