using ConsoleApp.DesignPatterns.Creational.Builder.GoodExample.Components;

namespace ConsoleApp.DesignPatterns.Creational.Builder.GoodExample;

public class Director
{
    public void ConstructSportsCar(IBuilder builder)
    {
        builder.SetCarType(CarType.Sports);
        builder.SetDashboard(new Dashboard(true));
        builder.SetEngine(new Engine());
        builder.SetSeats(2);
        builder.SetWheels(new Wheels(20));
    }

    public void ConstructSUV(IBuilder builder)
    {
        builder.SetCarType(CarType.SUV);
        builder.SetDashboard(new Dashboard(true));
        builder.SetEngine(new Engine());
        builder.SetGPSNavigator(new GPSNavigator());
        builder.SetSeats(5);
        builder.SetWheels(new Wheels(19));
    }
}