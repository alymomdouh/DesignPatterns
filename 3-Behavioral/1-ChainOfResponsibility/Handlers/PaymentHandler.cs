using _1_ChainOfResponsibility.Main;

namespace _1_ChainOfResponsibility.Handlers
{
    public class PaymentHandler : BaseHandler
    {
        public override void Handle(User user, Product product, int quantity)
        {
            decimal total = product.Price * quantity;
            bool paymentSuccess = Withdraw(user, total);
            if (!paymentSuccess)
            {
                Console.WriteLine("❌ Payment failed.");
                return;
            }

            base.Handle(user, product, quantity);
        }


        private bool Withdraw(User user, decimal amount)
        {
            if (user.Balance >= amount)
            {
                user.Balance -= amount;
                return true;
            }
            return false;
        }
    }
}
