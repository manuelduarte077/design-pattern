namespace ConsoleApp.DesignPatterns.Structural.Bridge.BadExample;

public class LGRemote : RemoteControl
{
    public override void TurnOff()
    {
        Console.WriteLine("Turning LG radio off");
    }

    public override void TurnOn()
    {
        Console.WriteLine("Turning LG radio on");
    }

    public override void VolumeDown()
    {
        Console.WriteLine("Turning LG radio volume down");
    }

    public override void VolumeUp()
    {
        Console.WriteLine("Turning LG radio volume up");
    }
}