namespace ConsoleApp.DesignPatterns.Behavioral.Template.InheritanceExample;

public class Coffee : Beverage
{
    protected override void Brew()
    {
        Console.WriteLine("Brewing coffee for 5 mins");
    }

    protected override void AddCondiments()
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