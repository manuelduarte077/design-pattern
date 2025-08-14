namespace ConsoleApp.DesignPatterns.Creational.Builder.GoodExample.Components;

public class Wheels
{
    private readonly float _diameterInInches;

    public Wheels(float diameterInInches)
    {
        _diameterInInches = diameterInInches;
    }

    public float GetDiameterInInches()
    {
        return _diameterInInches;
    }
}