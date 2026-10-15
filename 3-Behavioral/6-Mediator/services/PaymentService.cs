namespace _6_Mediator.services
{
    public class PaymentService
    {
        public void ProcessPayment(int orderId)
        {
            Console.WriteLine(
                $"Payment processed for Order #{orderId}");
        }
    }
}
