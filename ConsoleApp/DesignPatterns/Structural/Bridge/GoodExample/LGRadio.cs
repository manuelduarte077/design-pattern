namespace ConsoleApp.DesignPatterns.Structural.Bridge.GoodExample;

public class LGRadio : Device
{
    public void TurnOff()
    {
        Console.WriteLine("Turning LG radio off");
    }

    public void TurnOn()
    {
        Console.WriteLine("Turning LG radio on");
    }

    public void SetChannel(int channel)
    {
        Console.WriteLine("Setting LG radio channel to " + channel);
    }
}