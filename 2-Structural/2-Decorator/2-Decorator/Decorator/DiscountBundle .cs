namespace _2_Decorator.Decorator
{
    public class DiscountBundle : BundleDecorator
    {
        private float discountRate;

        public DiscountBundle(IInvoiceItem invoiceItem, float discountRate)
            : base(invoiceItem)
        {
            this.discountRate = discountRate;
        }

        public override string GetDetails()
        {
            return invoiceItem.GetDetails() + $" + Discount Rate ({discountRate})";
        }

        public override float GetPrice()
        {
            return invoiceItem.GetPrice() * (1 - discountRate);
        }
    }
}