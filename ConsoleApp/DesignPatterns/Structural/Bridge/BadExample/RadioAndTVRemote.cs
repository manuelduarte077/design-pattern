namespace ConsoleApp.DesignPatterns.Structural.Bridge.BadExample;

public abstract class RadioAndTVRemote : RemoteControl
{
    public abstract void ControlTV();

    public abstract void ControlRadio();
}