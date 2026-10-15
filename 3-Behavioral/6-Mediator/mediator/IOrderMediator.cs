namespace _6_Mediator.mediator
{
    public interface IOrderMediator
    {
        void ProcessOrder(
            int orderId,
            int productId,
            int quantity,
            string customerEmail);
    }
}
