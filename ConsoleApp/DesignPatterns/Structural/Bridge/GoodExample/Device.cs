namespace ConsoleApp.DesignPatterns.Structural.Bridge.GoodExample;

public interface Device
{
    public void TurnOn();

    public void TurnOff();

    public void SetChannel(int channel);
}