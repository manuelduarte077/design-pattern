using ConsoleApp.DesignPatterns.Creational.FactoryMethod.BadExample2.BackendFramework;

namespace ConsoleApp.DesignPatterns.Creational.FactoryMethod.BadExample2.TwigView;

public class TwigViewEngine : ViewEngine
{
    public string Render(string fileName, Dictionary<string, object> data)
    {
        return "View rendered from " + fileName + " by Twig";
    }
}