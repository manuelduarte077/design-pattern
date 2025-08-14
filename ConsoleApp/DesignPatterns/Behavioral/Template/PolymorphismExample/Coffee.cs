namespace ConsoleApp.DesignPatterns.Behavioral.Template.PolymorphismExample;

public class Coffee : Beverage
{
    public void Prepare()
    {
        Brew();
        AddCondiments();
    }

    private void Brew()
    {
        Console.WriteLine("Brewing coffee for 5 minutes");
    }

    private void AddCondiments()
    {
        if (CustomerWantsCondiments())
            Console.WriteLine("Adding cream to coffee");
    }

    private bool CustomerWantsCondiments()
    {
        Console.WriteLine("Would you like cream with your coffee? (y/n)");
        var input = Console.ReadLine();
        return input.ToLower() == "y";
    }
}