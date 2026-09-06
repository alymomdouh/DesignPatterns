namespace _2_Decorator.Decorator
{
    public class Product : IInvoiceItem
    {
        private string name;
        private float price;

        public Product(string name, float price)
        {
            this.name = name;
            this.price = price;
        }
        public string GetDetails()
        {
            return $"{name} : {price}";
        }

        public float GetPrice()
        {
            return price;
        }
    }
}
