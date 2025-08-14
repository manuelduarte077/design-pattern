namespace ConsoleApp.DesignPatterns.Behavioral.Observer.GoodExample;

public class BarChart : Observer
{
    private DataSource _dataSource;

    public BarChart(DataSource dataSource)
    {
        _dataSource = dataSource;
    }

    public void Update()
    {
        Console.WriteLine("Rendering bar chart with new values");
    }
}