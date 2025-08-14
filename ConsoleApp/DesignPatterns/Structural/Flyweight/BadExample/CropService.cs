namespace ConsoleApp.DesignPatterns.Structural.Flyweight.BadExample;

public class CropService
{
    public List<Crop> GetCrops()
    {
        var cropList = new List<Crop>();

        // Simulate fetching from database/api
        var carrot = new Crop(1, 4, CropType.Carrot, null); // passing null for icon for convenience
        var carrot2 = new Crop(1, 5, CropType.Carrot, null);
        var carrot3 = new Crop(1, 6, CropType.Carrot, null);

        cropList.Add(carrot);
        cropList.Add(carrot2);
        cropList.Add(carrot3);
        return cropList;
    }
}