using _1_ChainOfResponsibility.Main;

namespace _1_ChainOfResponsibility.Handlers
{
    public class AuthinticatioHandler : BaseHandler
    {
        public override void Handle(User user, Product product, int quantity)
        {
            if (!user.IsAuthenticated)
            {
                Console.WriteLine("❌ User is not authenticated.");
                return;
            }

            Console.WriteLine("User is  authenticated.");

            base.Handle(user, product, quantity);
        }
    }
}