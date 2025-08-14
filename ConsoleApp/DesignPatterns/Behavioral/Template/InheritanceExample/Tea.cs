namespace ConsoleApp.DesignPatterns.Behavioral.Template.InheritanceExample;

public class Tea : Beverage
{
    // Tea is brewed for 3 mins, so no need to override Beverage.Brew()

    protected override void AddCondiments()
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