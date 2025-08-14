namespace ConsoleApp.DesignPatterns.Behavioral.Command.RemoteControl.GoodExample;

public class TurnOffCommand : ICommand
{
    private readonly Light _light;

    public TurnOffCommand(Light light)
    {
        _light = light;
    }

    public void Execute()
    {
        _light.TurnOff();
    }
}