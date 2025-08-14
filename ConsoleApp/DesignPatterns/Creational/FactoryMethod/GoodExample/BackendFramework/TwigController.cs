using ConsoleApp.DesignPatterns.Creational.FactoryMethod.GoodExample.TwigView;

namespace ConsoleApp.DesignPatterns.Creational.FactoryMethod.GoodExample.BackendFramework;

public class TwigController : Controller
{
    protected override ViewEngine CreateViewEngine()
    {
        return new TwigViewEngine();
    }
}