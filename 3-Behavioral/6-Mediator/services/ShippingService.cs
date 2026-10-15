namespace _6_Mediator.services
{
    public class ShippingService
    {
        public void CreateShipment(int orderId)
        {
            Console.WriteLine(
                $"Shipment created for Order #{orderId}");
        }
    }
}
