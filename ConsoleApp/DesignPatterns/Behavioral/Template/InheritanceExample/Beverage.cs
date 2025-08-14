namespace ConsoleApp.DesignPatterns.Behavioral.Template.InheritanceExample;

public class Beverage
{
    public void Prepare()
    {
        BoilWater();
        PourIntoCup();
        Brew();
        AddCondiments();
    }

    private void BoilWater()
    {
        Console.WriteLine("Boiling water");
    }

    private void PourIntoCup()
    {
        Console.WriteLine("Pouring into cup");
    }

    // Protected, so only available to this class and subclasses
    protected virtual void Brew()
    {
        // provide a default implementation, so, if not overridden, beverage is brewed for 3 mins
        Console.WriteLine("Brewing for 3 mins");
    }

    // Empty body, as no condiments by default
    protected virtual void AddCondiments()
    {
    }
}