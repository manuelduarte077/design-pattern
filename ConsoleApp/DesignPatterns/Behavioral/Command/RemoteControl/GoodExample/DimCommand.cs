namespace ConsoleApp.DesignPatterns.Behavioral.Command.RemoteControl.GoodExample;

public class DimCommand : ICommand
{
    private readonly Light _light;

    public DimCommand(Light light)
    {
        _light = light;
    }

    public void Execute()
    {
        _light.Dim();
    }
}