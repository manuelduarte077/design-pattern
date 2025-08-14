namespace ConsoleApp.DesignPatterns.Behavioral.Template.PolymorphismExample;

public class BeverageMaker
{
    private Beverage _beverage;

    public BeverageMaker(Beverage beverage)
    {
        _beverage = beverage;
    }

    public void SetBeverage(Beverage beverage)
    {
        _beverage = beverage;
    }

    public void MakeBeverage()
    {
        // Common operations
        BoilWater();
        PourIntoCup();

        // Unique operations
        _beverage.Prepare();
    }

    private void BoilWater()
    {
        Console.WriteLine("Boiling water");
    }

    private void PourIntoCup()
    {
        Console.WriteLine("Pouring boiled water into cup");
    }
}