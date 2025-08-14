using ConsoleApp.DesignPatterns.Structural.Adapter.ThirdPartyColorLibrary;

namespace ConsoleApp.DesignPatterns.Structural.Adapter;

// Adapter class. Rainbow is the adaptee
public class RainbowColor : Color
{
    private readonly Rainbow
        _rainbow; // "composition" -- RainbowColor is composed of, "has a", Rainbow. See RainbowAdapter for inheritance alternative.

    public RainbowColor(Rainbow rainbow)
    {
        _rainbow = rainbow;
    }

    public void Apply(Video video)
    {
        _rainbow.Setup();
        _rainbow.Update(video);
    }
}