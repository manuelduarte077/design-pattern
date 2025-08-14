namespace ConsoleApp.DesignPatterns.Structural.Composite.BadExample;

public class Box
{
    private readonly List<object> items = new();

    public void Add(object item)
    {
        items.Add(item);
    }

    // This method is UGLY!!! We need polymorphism!!
    public float CalculateTotalPrice()
    {
        float totalPrice = 0;
        foreach (var item in items)
            if (item is Keyboard)
                totalPrice += ((Keyboard)item).Price; // cast item to Keyboard object then we can get it's Price
            else if (item is Mouse)
                totalPrice += ((Mouse)item).Price;
            else if (item is Microphone)
                totalPrice += ((Microphone)item).Price;
            else if
                (item is Box) totalPrice += ((Box)item).CalculateTotalPrice(); // call CalculateTotalPrice() recursively

        return totalPrice;
    }
}