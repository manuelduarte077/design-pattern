namespace ConsoleApp.DesignPatterns.Creational.FactoryMethod.BadExample2.BackendFramework;

public class Controller
{
    public void Render(string fileName, Dictionary<string, object> data, ViewEngine viewEngine)
    {
        var html = viewEngine.Render(fileName, data);
        Console.WriteLine(html);
    }
}