namespace ConsoleApp.DesignPatterns.Structural.Bridge.GoodExample;

public class RemoteControl
{
    private readonly Device _device;

    public RemoteControl(Device device)
    {
        _device = device;
    }

    public void TurnOn()
    {
        _device.TurnOn();
    }

    public void TurnOff()
    {
        _device.TurnOff();
    }

    // other basic remote methods...
}