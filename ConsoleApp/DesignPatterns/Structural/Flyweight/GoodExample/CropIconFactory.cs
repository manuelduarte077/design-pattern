namespace ConsoleApp.DesignPatterns.Structural.Flyweight.GoodExample;

// This class ensures that each unique crop icon object is created only once, cached, and reused/shared between crop objects.
public class CropIconFactory
{
    // Icon cache
    private readonly Dictionary<CropType, CropIcon> _icons = new();

    public CropIcon GetCropIcon(CropType cropType)
    {
        // check if icon already exists
        if (!_icons.ContainsKey(cropType))
        {
            // icon doesn't exist, so create one and add it to cache
            var icon = new CropIcon(cropType,
                null); // using null for convenience, but this could be, for example, a reference to file location
            _icons.Add(cropType, icon);
        }

        // here, we know the icon exists, so retrieve it from cache and return it
        return _icons[cropType];
    }
}