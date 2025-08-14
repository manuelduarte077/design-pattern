using ConsoleApp.DesignPatterns.Creational.Builder.BadExample.Components;

namespace ConsoleApp.DesignPatterns.Creational.Builder.BadExample;

public class Manual
{
    public Dashboard _dashboard;
    public Engine _engine;
    public GPSNavigator _gpsNavigator;
    public bool _isConvertible;
    public int _seats;
    public CarType _type;
    public Wheels _wheels;

    public Manual(
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

    public string Print()
    {
        var text = "";

        text += "Car type: " + _type + "\n";
        text += "Seats: " + _seats + "\n";
        text += "Wheels: diameter in inches = " + _wheels.GetDiameterInInches() + "\n";
        text += "Engine: info on engine... \n";
        text += "GPS Navigator: ";
        if (_gpsNavigator != null)
            text += "Info on gps... \n";
        else
            text += "N/A \n";

        return text;
    }
}