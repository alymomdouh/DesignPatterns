using _1_ChainOfResponsibility.Main;

namespace _1_ChainOfResponsibility.Handlers
{
    internal class NotificationHandler : BaseHandler
    {
        public override void Handle(User user, Product product, int quantity)
        {
            Console.WriteLine($"📧 Email sent to {user.Email}");

            Console.WriteLine("\n🏁 Process Complete.");

            base.Handle(user, product, quantity);
        }


    }
}
