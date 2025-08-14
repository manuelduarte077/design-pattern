namespace ConsoleApp.DesignPatterns.Structural.Bridge.GoodExample;

public class AdvancedRemote : RemoteControl
{
    public AdvancedRemote(Device device) : base(device)
    {
    }

    public void SetChannel(int channel)
    {
        Console.WriteLine("Setting channel to " + channel);
    }
}