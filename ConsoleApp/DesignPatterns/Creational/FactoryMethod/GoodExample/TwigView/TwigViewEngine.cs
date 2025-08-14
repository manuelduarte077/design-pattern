using ConsoleApp.DesignPatterns.Creational.FactoryMethod.GoodExample.BackendFramework;

namespace ConsoleApp.DesignPatterns.Creational.FactoryMethod.GoodExample.TwigView;

public class TwigViewEngine : ViewEngine
{
    public string Render(string fileName, Dictionary<string, object> data)
    {
        return "View rendered from " + fileName + " by Twig";
    }
}