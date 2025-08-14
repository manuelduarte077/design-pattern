namespace ConsoleApp.DesignPatterns.Behavioral.Template.BadExample;

public class Coffee
{
    public void MakeBeverage()
    {
        BoilWater();
        PourWaterIntoCup();
        Brew();
        AddCondiments();
    }

    private void BoilWater()
    {
        Console.WriteLine("Boiling water");
    }

    private void PourWaterIntoCup()
    {
        Console.WriteLine("Pouring water into cup");
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