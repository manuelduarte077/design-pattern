namespace ConsoleApp.DesignPatterns.Creational.FactoryMethod.BadExample1.BackendFramework;

public interface ViewEngine
{
    string Render(string fileName, Dictionary<string, object> data);
}