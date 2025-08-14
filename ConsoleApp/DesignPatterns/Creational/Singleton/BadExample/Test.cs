namespace ConsoleApp.DesignPatterns.Creational.Singleton.BadExample;

public class Test
{
    public void Run()
    {
        var settingsElsewhere = new AppSettings();
        Console.WriteLine(
            settingsElsewhere
                .Get("app_name")); // null -- we need to use Singleton pattern to ensure a single instance of AppSettings is maintained throughout our app
    }
}