namespace ConsoleApp.DesignPatterns.Behavioral.Visitor.GoodExample;

public class PDFExportVisitor : Visitor
{
    public void VisitLaw(Law law)
    {
        Console.WriteLine("Exporting law client as PDF.");
    }

    public void VisitRestaurant(Restaurant restaurant)
    {
        Console.WriteLine("Exporting restaurant client as PDF.");
    }

    public void VisitRetail(Retail retail)
    {
        Console.WriteLine("Exporting retail client as PDF.");
    }
}