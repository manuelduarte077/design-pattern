using ConsoleApp.DesignPatterns.Creational.FactoryMethod.GoodExample.BackendFramework;

namespace ConsoleApp.DesignPatterns.Creational.FactoryMethod.GoodExample.BladeView;

public class BladeViewEngine : ViewEngine
{
    public string Render(string fileName, Dictionary<string, object> data)
    {
        return "View rendered from " + fileName + " by Blade";
    }
}