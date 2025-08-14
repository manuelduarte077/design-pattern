namespace ConsoleApp.DesignPatterns.Structural.Bridge.GoodExample;

public class SonyRadio : Device
{
    public void TurnOff()
    {
        Console.WriteLine("Turning Sony radio off");
    }

    public void TurnOn()
    {
        Console.WriteLine("Turning Sony radio on");
    }

    public void SetChannel(int channel)
    {
        Console.WriteLine("Setting Sony radio channel to " + channel);
    }
}