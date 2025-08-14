namespace ConsoleApp.DesignPatterns.Behavioral.Observer.GoodExample;

public class Sheet2 : Observer
{
    private readonly DataSource _dataSource;
    private int _total;

    public Sheet2(DataSource dataSource)
    {
        _dataSource = dataSource;
    }

    public void Update()
    {
        var sum = CalculateTotal(_dataSource.GetValues());
        Console.WriteLine("Total: " + sum);
        _total = sum;
    }

    public int GetTotal()
    {
        return _total;
    }

    private int CalculateTotal(List<int> values)
    {
        var sum = 0;
        foreach (var value in values) sum += value;
        return sum;
    }
}