namespace ConsoleApp.DesignPatterns.Behavioral.Observer.GoodExample;

public class DataSource : Subject
{
    private List<int> _values = new();

    public List<int> GetValues()
    {
        return _values;
    }

    public void SetValues(List<int> values)
    {
        _values = values;

        NotifyObservers();
    }
}