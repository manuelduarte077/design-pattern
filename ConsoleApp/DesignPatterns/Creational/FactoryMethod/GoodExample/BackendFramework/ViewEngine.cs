namespace ConsoleApp.DesignPatterns.Creational.FactoryMethod.GoodExample.BackendFramework;

public interface ViewEngine
{
    string Render(string fileName, Dictionary<string, object> data);
}