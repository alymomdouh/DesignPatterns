namespace _3_Composite
{
    public class Product : ICartItem
    {
        public string Name { get; set; }
        public decimal Price { get; set; }

        public decimal GetPrice() => Price;


        public void Print(int indent = 0)
        {
            Console.WriteLine($"{new string(' ', indent)}Product: {Name} - {GetPrice()}");
        }
    }
}