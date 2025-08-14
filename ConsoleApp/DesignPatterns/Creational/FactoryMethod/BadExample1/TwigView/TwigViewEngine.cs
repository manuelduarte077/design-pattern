using ConsoleApp.DesignPatterns.Creational.FactoryMethod.BadExample1.BackendFramework;

namespace ConsoleApp.DesignPatterns.Creational.FactoryMethod.BadExample1.TwigView;

public class TwigViewEngine : ViewEngine
{
    public string Render(string fileName, Dictionary<string, object> data)
    {
        return "View rendered from " + fileName + " by Twig";
    }
}