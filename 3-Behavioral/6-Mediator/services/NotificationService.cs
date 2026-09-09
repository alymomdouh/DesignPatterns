namespace _6_Mediator.services
{
    public class NotificationService
    {
        public void SendOrderConfirmation(
            string email,
            int orderId)
        {
            Console.WriteLine(
                $"Confirmation email sent to {email} for Order #{orderId}");
        }
    }
}
