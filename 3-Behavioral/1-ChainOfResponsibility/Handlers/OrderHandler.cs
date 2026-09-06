using _1_ChainOfResponsibility.Main;

namespace _1_ChainOfResponsibility.Handlers
{
    public class OrderHandler : BaseHandler
    {
        public override void Handle(User user, Product product, int quantity)
        {
            int orderId = CreateOrder(user.Id, product.Id, quantity);
            Console.WriteLine($"✅ Order #{orderId} created successfully.");

            base.Handle(user, product, quantity);
        }

        private int CreateOrder(int userId, int productId, int quantity)
        {
            return new Random().Next(1000, 9999);
        }
    }
}
