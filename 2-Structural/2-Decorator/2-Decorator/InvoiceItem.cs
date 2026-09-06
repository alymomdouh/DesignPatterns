namespace _2_Decorator
{
    public class InvoiceItem
    {
        public string Name { get; set; }
        public float BasePrice { get; set; }

        public bool HasGiftWrap { get; set; }
        public float GiftWrapCost { get; set; }

        public bool HasDiscount { get; set; }
        public float DiscountRate { get; set; }

        public float GetPrice()
        {
            float price = BasePrice;
            if (HasGiftWrap)
                price += GiftWrapCost;

            if (HasDiscount)
                price *= 1 - DiscountRate;

            return price;
        }
    }
}
