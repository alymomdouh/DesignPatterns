using _1_ChainOfResponsibility.Main;

namespace _1_ChainOfResponsibility.Handlers
{
    public class StockHandler : BaseHandler
    {
        public override void Handle(User user, Product product, int quantity)
        {

            if (product.Stock < quantity)
            {
                Console.WriteLine("❌ Product out of stock.");
                return;
            }

            Console.WriteLine("Product is in stock.");
            base.Handle(user, product, quantity);
        }
    }
}
