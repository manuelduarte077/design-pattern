namespace ConsoleApp.DesignPatterns.Behavioral.Observer.BadExample;

public class DataSource
{
    private readonly List<object> _dependents = new();

    private List<int> _values = new();

    public List<int> GetValues()
    {
        return _values;
    }

    public void SetValues(List<int> values)
    {
        _values = values;


        // We now need to update our dependent object
        foreach (var dependent in _dependents)
            // This is gonna be VERY messy if we end up with lots of dependents!!
            if (dependent is Sheet2)
                (dependent as Sheet2).CalculateTotal(_values);
            else if (dependent is BarChart) (dependent as BarChart).Render(_values);
    }

    public void AddDependent(object dependent)
    {
        _dependents.Add(dependent);
    }

    public void RemoveDependent(object dependent)
    {
        _dependents.Remove(dependent);
    }
}