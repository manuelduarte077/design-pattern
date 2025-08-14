using ConsoleApp.DesignPatterns.Creational.Builder.BadExample.Components;

namespace ConsoleApp.DesignPatterns.Creational.Builder.BadExample;

public class Car
{
    public Dashboard _dashboard;
    public Engine _engine;
    public GPSNavigator _gpsNavigator;
    public bool _isConvertible;
    public int _seats;
    public CarType _type;
    public Wheels _wheels;

    public Car(
        CarType type,
        int seats,
        bool isConvertible,
        Engine engine,
        Dashboard dashboard,
        Wheels wheels,
        GPSNavigator gpsNavigator
    )
    {
        _type = type;
        _seats = seats;
        _isConvertible = isConvertible;
        _engine = engine;
        _dashboard = dashboard;
        _wheels = wheels;
        _gpsNavigator = gpsNavigator;
    }

    // Fields specific to this class:
    public double Fuel { get; set; }
}