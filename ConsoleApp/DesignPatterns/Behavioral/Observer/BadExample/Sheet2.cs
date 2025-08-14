namespace ConsoleApp.DesignPatterns.Behavioral.Observer.BadExample;

public class Sheet2
{
    private int _total;

    public int GetTotal()
    {
        return _total;
    }

    public int CalculateTotal(List<int> values)
    {
        var sum = 0;
        foreach (var value in values) sum += value;
        Console.WriteLine("Total: " + sum);
        return sum;
    }
}