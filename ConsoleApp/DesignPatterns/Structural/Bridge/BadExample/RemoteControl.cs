namespace ConsoleApp.DesignPatterns.Structural.Bridge.BadExample;

// Base remote control class
public abstract class RemoteControl
{
    public abstract void TurnOn();

    public abstract void TurnOff();

    public abstract void VolumeUp();

    public abstract void VolumeDown();
}