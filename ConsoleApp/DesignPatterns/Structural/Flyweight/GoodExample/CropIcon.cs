namespace ConsoleApp.DesignPatterns.Structural.Flyweight.GoodExample;

// The Flyweight class stores intrinsic state -- the state that remains constant throughout the objects life
public class CropIcon
{
    private readonly byte[] _icon;

    // `readonly` ensures that once constructed, they cannot be changed later on.
    private readonly CropType _type;

    public CropIcon(CropType type, byte[] icon)
    {
        _type = type;
        _icon = icon;
    }

    public CropType GetType()
    {
        return _type;
    }
}