using _2_Decorator.Decorator;

namespace _2_Decorator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            #region Decorator Pattern Example
            // Create an invoice item with gift wrap and discount
            // This is a simple implementation without using the decorator pattern
            var item = new InvoiceItem
            {
                Name = "Laptop",
                BasePrice = 1000,
                HasGiftWrap = true,
                GiftWrapCost = 100,
                HasDiscount = true,
                DiscountRate = .1f
            }; 
            Console.WriteLine(item.GetPrice());
            #endregion

            var product = new Product("Laptop", 1000);
            var wrapped = new WrapBundle(product, 100);
            var insurance = new InsuranceBundle(wrapped, 100);
            var discout = new DiscountBundle(insurance, .1f);

            Console.WriteLine(insurance.GetDetails());
            Console.WriteLine(insurance.GetPrice());
            Console.WriteLine(discout.GetPrice());
        }
    }
}
