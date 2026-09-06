using _1_ChainOfResponsibility.Main;

namespace _1_ChainOfResponsibility.Handlers
{
    public class AuthorizationHandler : BaseHandler
    {
        public override void Handle(User user, Product product, int quantity)
        {

            if (!user.CanBuy)
            {
                Console.WriteLine("❌ User does not have permission to buy.");
                return;
            }


            Console.WriteLine("User has permission to buy.");

            base.Handle(user, product, quantity);
        }
    }
}
