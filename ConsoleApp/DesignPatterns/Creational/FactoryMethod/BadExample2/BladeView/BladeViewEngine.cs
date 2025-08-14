using ConsoleApp.DesignPatterns.Creational.FactoryMethod.BadExample2.BackendFramework;

namespace ConsoleApp.DesignPatterns.Creational.FactoryMethod.BadExample2.BladeView;

public class BladeViewEngine : ViewEngine
{
    public string Render(string fileName, Dictionary<string, object> data)
    {
        return "View rendered from " + fileName + " by Blade";
    }
}