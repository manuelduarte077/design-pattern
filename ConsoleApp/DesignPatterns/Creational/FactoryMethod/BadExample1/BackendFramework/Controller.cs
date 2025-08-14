using ConsoleApp.DesignPatterns.Creational.FactoryMethod.BadExample1.BladeView;

namespace ConsoleApp.DesignPatterns.Creational.FactoryMethod.BadExample1.BackendFramework;

public class Controller
{
    public void Render(string fileName, Dictionary<string, object> data)
    {
        var viewEngine =
            new BladeViewEngine(); // PROBLEM: Controller is tightly coupled to this particular view engine -- not flexible
        var html = viewEngine.Render(fileName, data);
        Console.WriteLine(html);
    }
}