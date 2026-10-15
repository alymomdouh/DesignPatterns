namespace _6_Mediator.mediator
{
    public class NewOrderService
    {
        private readonly IOrderMediator _mediator;

        public NewOrderService(IOrderMediator mediator)
        {
            _mediator = mediator;
        }

        public void CreateOrder(
            int orderId,
            int productId,
            int quantity,
            string customerEmail)
        {
            Console.WriteLine("Creating order...");

            _mediator.ProcessOrder(
                orderId,
                productId,
                quantity,
                customerEmail);
        }
    }
}
}
