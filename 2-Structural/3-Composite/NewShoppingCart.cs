namespace _3_Composite
{
    public class NewShoppingCart
    {
        private readonly List<ICartItem> _items = new();

        public void AddItem(ICartItem item) => _items.Add(item);

        public decimal CalculateTotal() => _items.Sum(i => i.GetPrice());


        public void Print()
        {
            Console.WriteLine("Shopping Cart");

            foreach (var item in _items)
                item.Print(4);

            Console.WriteLine($"Total = {CalculateTotal()}");
        }

    }
}