using ConsoleApp.DesignPatterns.Creational.FactoryMethod.BadExample1.BackendFramework;

namespace ConsoleApp.DesignPatterns.Creational.FactoryMethod.BadExample1.BladeView;

public class BladeViewEngine : ViewEngine
{
    public string Render(string fileName, Dictionary<string, object> data)
    {
        return "View rendered from " + fileName + " by Blade";
    }
}