namespace ConsoleApp.DesignPatterns.Behavioral.Template.PolymorphismExample;

public class Tea : Beverage
{
    public void Prepare()
    {
        Brew();
        AddCondiments();
    }

    private void Brew()
    {
        Console.WriteLine("Brewing tea for 3 minutes");
    }

    private void AddCondiments()
    {
        if (CustomerWantsCondiments())
            Console.WriteLine("Adding lemon to tea");
    }

    private bool CustomerWantsCondiments()
    {
        Console.WriteLine("Would you like lemon with your tea? (y/n)");
        var input = Console.ReadLine();
        return input.ToLower() == "y";
    }
}