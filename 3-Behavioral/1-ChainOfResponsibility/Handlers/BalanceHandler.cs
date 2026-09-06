using _1_ChainOfResponsibility.Main;

namespace _1_ChainOfResponsibility.Handlers
{
    public class BalanceHandler : BaseHandler
    {
        public override void Handle(User user, Product product, int quantity)
        {
            decimal total = product.Price * quantity;
            if (user.Balance < total)
            {
                Console.WriteLine("❌ Insufficient balance.");
                return;
            }

            base.Handle(user, product, quantity);
        }
    }
}
