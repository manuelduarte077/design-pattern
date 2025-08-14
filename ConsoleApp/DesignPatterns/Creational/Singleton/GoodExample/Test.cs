namespace ConsoleApp.DesignPatterns.Creational.Singleton.GoodExample;

public class Test
{
    public void Run()
    {
        var settings = AppSettings.GetInstance();
        Console.WriteLine(
            settings.Get(
                "app_creator")); // set app_creator in Main and it will return same value when this Run() method is called
    }
}