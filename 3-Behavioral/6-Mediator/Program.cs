using _6_Mediator.mediator;
using _6_Mediator.services;

namespace _6_Mediator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            #region old way

            // old way 
            //var paymentService = new PaymentService();
            //var inventoryService = new InventoryService();
            //var shippingService = new ShippingService();
            //var notificationService = new NotificationService();

            //var orderService = new OrderService(
            //    paymentService,
            //    inventoryService,
            //    shippingService,
            //    notificationService);

            //orderService.CreateOrder(
            //    orderId: 1001,
            //    productId: 50,
            //    quantity: 2,
            //    customerEmail: "aly@example.com");


            // the problem with the old way is that the OrderService is tightly coupled to the other services.
            // If we want to change the implementation of any of the services,
            // we have to change the OrderService as well. This violates the Open/Closed Principle.
            //OrderService knows about 4 different services.
            /*
            OrderService
                  │
                  ▼
              Mediator
                  │
        ┌─────────┼─────────┐
        ▼         ▼         ▼
     Payment Inventory  Shipping
                            │
                       Notification


            */

            #endregion


            #region  new way 

            // Create services

            var paymentService = new PaymentService();
            var inventoryService = new InventoryService();
            var shippingService = new ShippingService();
            var notificationService = new NotificationService();

            // Create Mediator

            IOrderMediator mediator = new OrderMediator(
                paymentService,
                inventoryService,
                shippingService,
                notificationService);

            // OrderService only knows the Mediator

            var orderService = new NewOrderService(mediator);

            // Create order

            orderService.CreateOrder(
                orderId: 1001,
                productId: 50,
                quantity: 2,
                customerEmail: "aly@example.com");

            #endregion


            /*
             🆚 Before vs After
                  Before
             
                  OrderService
                /      |       \
               /       |        \
              ▼        ▼         ▼
          Payment   Inventory  Shipping
                                  │
                                  ▼
                            Notification
             
                  After

                   OrderService
                      │
                      ▼
                  Mediator
                      │
        ┌─────────────┼─────────────┐
        ▼             ▼             ▼
     Payment       Inventory      Shipping
                                      │
                                      ▼
                                Notification
             
             */
        }
    }
}
