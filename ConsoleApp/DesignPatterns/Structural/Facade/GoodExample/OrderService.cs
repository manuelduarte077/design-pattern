namespace ConsoleApp.DesignPatterns.Structural.Facade.GoodExample;

// "Facade" that encapsulates all the complexities and steps involved in making an order, so clients can make orders without having to know all of the details
public class OrderService
{
    public void Order(OrderRequest orderReq)
    {
        var auth = new BadExample.Authenticate();

        var inventory = new Inventory();
        foreach (var id in orderReq.ItemIds) inventory.CheckInventory(id);

        var payment = new Payment(orderReq.Name, orderReq.CardNumber, orderReq.Amount);
        payment.Pay();

        var orderFulfillment = new OrderFulfillment(inventory);
        orderFulfillment.Fulfill(orderReq.Name, orderReq.Address, orderReq.ItemIds);
    }
}