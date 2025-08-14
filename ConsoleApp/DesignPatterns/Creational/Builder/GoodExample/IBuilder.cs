using ConsoleApp.DesignPatterns.Creational.Builder.GoodExample.Components;

namespace ConsoleApp.DesignPatterns.Creational.Builder.GoodExample;

public interface IBuilder
{
    void Reset();
    IBuilder SetCarType(CarType type);
    IBuilder SetSeats(int seats);
    IBuilder IsConvertible(bool isConvertible);
    IBuilder SetEngine(Engine engine);
    IBuilder SetWheels(Wheels wheels);
    IBuilder SetDashboard(Dashboard dashboard);
    IBuilder SetGPSNavigator(GPSNavigator gpsNavigator);
}