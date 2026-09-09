using _6_Mediator.services;

namespace _6_Mediator.mediator
{
    public class OrderMediator : IOrderMediator
    {
        private readonly PaymentService _paymentService;
        private readonly InventoryService _inventoryService;
        private readonly ShippingService _shippingService;
        private readonly NotificationService _notificationService;

        public OrderMediator(
            PaymentService paymentService,
            InventoryService inventoryService,
            ShippingService shippingService,
            NotificationService notificationService)
        {
            _paymentService = paymentService;
            _inventoryService = inventoryService;
            _shippingService = shippingService;
            _notificationService = notificationService;
        }

        public void ProcessOrder(
            int orderId,
            int productId,
            int quantity,
            string customerEmail)
        {
            Console.WriteLine("Processing order through Mediator...");

            _paymentService.ProcessPayment(orderId);

            _inventoryService.RemoveStock(
                productId,
                quantity);

            _shippingService.CreateShipment(orderId);

            _notificationService.SendOrderConfirmation(
                customerEmail,
                orderId);

            Console.WriteLine("Order processed successfully.");
        }
    }
}
