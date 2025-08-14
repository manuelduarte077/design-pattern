namespace ConsoleApp.DesignPatterns.Structural.Flyweight.GoodExample;

// Extrinsic, dynamic, state stored here. Intrinsic state, CropIcon -- the Flyweight class -- is referenced.
public class Crop
{
    private readonly CropIcon _cropIcon;
    private readonly int _x;
    private readonly int _y;

    public Crop(int x, int y, CropIcon cropIcon)
    {
        _x = x;
        _y = y;
        _cropIcon = cropIcon;
    }

    public void Render()
    {
        Console.WriteLine($"Drawing {_cropIcon.GetType()} at ({_x}, {_y})");
    }
}