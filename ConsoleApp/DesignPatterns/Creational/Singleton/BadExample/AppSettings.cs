namespace ConsoleApp.DesignPatterns.Creational.Singleton.BadExample;

public class AppSettings
{
    private readonly Dictionary<string, object> _settings = new();

    public object Get(string key)
    {
        if (!_settings.ContainsKey(key))
            return null;

        return _settings[key];
    }

    public void Set(string key, object value)
    {
        _settings[key] = value;
    }
}