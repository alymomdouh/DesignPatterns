using _1_ChainOfResponsibility.Main;

namespace _1_ChainOfResponsibility
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.OutputEncoding = System.Text.Encoding.UTF8;


            var user = new User
            {
                Id = 1,
                IsAuthenticated = true,
                CanBuy = true,
                Balance = 500,
                Email = "customer@example.com"
            };

            var product = new Product
            {
                Id = 100,
                Price = 120,
                Stock = 5
            };

            int quantity = 2;

            var processor = new OrderProcessor();
            processor.Process(user, product, quantity);

            var chainBuilder = new OrderHandlerChainBuiler();
            var handler = chainBuilder.Build();
            handler.Handle(user, product, quantity);
        }
    }
}
