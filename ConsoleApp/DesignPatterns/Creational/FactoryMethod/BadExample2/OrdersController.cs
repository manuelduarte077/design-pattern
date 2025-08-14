using ConsoleApp.DesignPatterns.Creational.FactoryMethod.BadExample2.BackendFramework;
using ConsoleApp.DesignPatterns.Creational.FactoryMethod.BadExample2.TwigView;

namespace ConsoleApp.DesignPatterns.Creational.FactoryMethod.BadExample2;

public class OrdersController : Controller
{
    public void ListOrders()
    {
        // Simulate fetching users previous orders from db
        var orders = new Dictionary<string, object>
        {
            { "Red socks", "$12.98" },
            { "Black socks", "$12.98" },
            { "Pink T-shirt", "29.00" }
        };

        // Problem: we have to pass the view engine every time we call Render.
        Render("orders.php", orders, new TwigViewEngine());
    }

    public void GetOrder(int id)
    {
        // Simulate getting single order by id from db
        var order = new Dictionary<string, object>
        {
            { "Red Socks", "$12.98" }
        };

        Render("order.php", order, new TwigViewEngine());
    }
}