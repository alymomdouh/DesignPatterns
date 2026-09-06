namespace _2_Decorator.Decorator
{
    public abstract class BundleDecorator : IInvoiceItem
    {

        protected IInvoiceItem invoiceItem;

        public BundleDecorator(IInvoiceItem invoiceItem)
        {
            this.invoiceItem = invoiceItem;
        }
        public abstract string GetDetails();

        public abstract float GetPrice();
    }
}