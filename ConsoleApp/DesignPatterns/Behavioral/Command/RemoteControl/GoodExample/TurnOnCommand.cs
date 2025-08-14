namespace ConsoleApp.DesignPatterns.Behavioral.Command.RemoteControl.GoodExample;

public class TurnOnCommand : ICommand
{
    private readonly Light _light;

    public TurnOnCommand(Light light)
    {
        _light = light; // _light can only be set in constructor, so command is immutable (can't be changed once created)
    }

    public void Execute()
    {
        _light.TurnOn(); // business logic is delegated to Light object
    }
}