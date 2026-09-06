namespace _3_Composite
{
    public class Bundle : ICartItem
    {
        public string Name { get; set; }
        public List<ICartItem> Items { get; set; }
        public decimal Discount { get; set; }

        public Bundle()
        {
            Items = new List<ICartItem>();
        }


        public void Add(ICartItem item) => Items.Add(item);

        public decimal GetPrice()
        {
            return Items.Sum(item => item.GetPrice()) - Discount;
        }

        public void Print(int indent = 0)
        {
            Console.WriteLine($"{new string(' ', indent)}Bundle: {Name} - {GetPrice()}");

            foreach (var item in Items)
                item.Print(indent + 4);
        }
    }
} 
