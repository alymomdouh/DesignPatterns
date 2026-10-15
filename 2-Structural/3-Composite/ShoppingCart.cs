namespace _3_Composite
{
    public class ShoppingCart
    {
        private readonly List<object> _items = new();

        public void AddItem(object item) => _items.Add(item);

        public decimal CalculateTotal()
        {
            decimal total = 0;
            foreach (var item in _items)
            {
                if (item is Product p)
                    total += p.Price;

                else if (item is GiftItem g)
                    total += 0;

                else if (item is Bundle bu)
                    total += bu.Items.Sum(item => item.GetPrice()) - bu.Discount; 

            }
            return total;
        }

        public void PrintItems()
        {
            foreach (var item in _items)
            {

                if (item is Product p)
                    Console.WriteLine($"{p.Name}: {p.Price}");

                else if (item is GiftItem g)
                    Console.WriteLine($"{g.Name}: 0");

                else if (item is Bundle b)
                {
                    decimal bundleTotal = b.Items.Sum(it =>
                        it is Product pr ? pr.Price :
                        it is GiftItem ? 0 :
                        0
                    ) - b.Discount;

                    Console.WriteLine($"{b.Name} (bundle): {bundleTotal}");
                }

            }

            Console.WriteLine($"Total: {CalculateTotal()}");
        }
    }
}
