namespace ConsoleApp.DesignPatterns.Behavioral.Template.PolymorphismExample;

public class Camomile : Beverage
{
    public void Prepare()
    {
        Brew();
    }

    public void Brew()
    {
        Console.WriteLine("Brewing for 3 mins");
    }
}