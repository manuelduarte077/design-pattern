namespace ConsoleApp.DesignPatterns.Structural.Facade.BadExample;

public class Payment
{
    private readonly float _amount;
    private readonly string _cardNumber;
    private readonly string _name;

    public Payment(string name, string cardNumber, float amount)
    {
        _name = name;
        _cardNumber = cardNumber;
        _amount = amount;
    }

    public void Pay()
    {
        Console.WriteLine("Charging card with name " + _name);
    }
}