namespace _3_Composite
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            //var cart = new ShoppingCart();


            //var bundle = new Bundle
            //{
            //    Name = "Back to school",
            //    Items = new List<Product>
            //{
            //    new Product{Name="Laptop",Price=2000},
            //    new Product{Name="Adpter",Price=500},
            //    new Product{Name="Monitor",Price=1000},
            //},
            //    Discount = 500
            //};
            //cart.AddItem(new Product { Name = "Mouse", Price = 200 });
            //cart.AddItem(new Product { Name = "Keyboard", Price = 300 });
            //cart.AddItem(new GiftItem { Name = "Mouse Pad" });
            //cart.AddItem(bundle);

            //cart.PrintItems();

             

            var mouse = new Product { Name = "Mouse", Price = 200 };
            var keyboard = new Product { Name = "Keyboard", Price = 300 };
            var laptop = new Product { Name = "Laptop", Price = 2000 };
            var monitor = new Product { Name = "Monitor", Price = 1000 };
            var Adapter = new Product { Name = "Adapter", Price = 800 };
            var sticker = new GiftItem { Name = "Sticker" };

            var laptopBundle = new Bundle { Name = "Laptop Bundle", Discount = 500 };
            laptopBundle.Add(mouse);
            laptopBundle.Add(keyboard);
            laptopBundle.Add(sticker);
            laptopBundle.Add(laptop);

            var mainBundle = new Bundle { Name = "Main Offer", Discount = 1000 };
            mainBundle.Add(monitor);
            mainBundle.Add(Adapter);
            mainBundle.Add(laptopBundle);


            var cart = new NewShoppingCart();
            cart.AddItem(mainBundle);

            cart.Print();
        }
    }
}
