namespace _6_Mediator.services
{
    public class OrderService(
        PaymentService paymentService,
        InventoryService inventoryService,
        ShippingService shippingService,
        NotificationService notificationService)
    {
        private readonly PaymentService _paymentService = paymentService;
        private readonly InventoryService _inventoryService = inventoryService;
        private readonly ShippingService _shippingService = shippingService;
        private readonly NotificationService _notificationService = notificationService;
        public void CreateOrder(
       int orderId,
       int productId,
       int quantity,
       string customerEmail)
        {
            Console.WriteLine("Creating order...");

            _paymentService.ProcessPayment(orderId);

            _inventoryService.RemoveStock(productId, quantity);

            _shippingService.CreateShipment(orderId);

            _notificationService.SendOrderConfirmation(
                customerEmail,
                orderId);

            Console.WriteLine("Order created successfully.");
        }
    }
}
