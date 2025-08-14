namespace ConsoleApp.DesignPatterns.Behavioral.Visitor.GoodExample;

public class EmailVisitor : Visitor
{
    public void VisitLaw(Law law)
    {
        Console.WriteLine("Sending law marketing tips email to " + law.GetEmail());
    }

    public void VisitRestaurant(Restaurant restaurant)
    {
        Console.WriteLine("Sending restaurant marketing tips email to " + restaurant.GetEmail());
    }

    public void VisitRetail(Retail retail)
    {
        Console.WriteLine("Sending retail marketing tips email to " + retail.GetEmail());
    }
}