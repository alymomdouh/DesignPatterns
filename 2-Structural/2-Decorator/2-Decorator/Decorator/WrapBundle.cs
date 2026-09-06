namespace _2_Decorator.Decorator
{
    public class WrapBundle : BundleDecorator
    {
        private float wrapCost;

        public WrapBundle(IInvoiceItem invoiceItem, float wrapCost)
            : base(invoiceItem)
        {
            this.wrapCost = wrapCost;
        }

        public override string GetDetails()
        {
            return invoiceItem.GetDetails() + $" + Wrap Cost ({wrapCost})";
        }

        public override float GetPrice()
        {
            return invoiceItem.GetPrice() + wrapCost;
        }
    }
}