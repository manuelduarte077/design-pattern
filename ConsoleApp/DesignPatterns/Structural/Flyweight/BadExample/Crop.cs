namespace ConsoleApp.DesignPatterns.Structural.Flyweight.BadExample;

public class Crop
{
    private readonly CropType _cropType; // 4 bytes
    private readonly int _x; // 4 bytes
    private readonly int _y; // 4 bytes

    private byte[]
        _icon; // 40 KB -> if there are 1000 points to render, that's 40 MB of memory. Many mobile devices would struggle with that.

    public Crop(int x, int y, CropType cropType, byte[] icon)
    {
        _x = x;
        _y = y;
        _cropType = cropType;
        _icon = icon;
    }

    public void Render()
    {
        Console.WriteLine($"Drawing {_cropType} at ({_x}, {_y})");
    }
}