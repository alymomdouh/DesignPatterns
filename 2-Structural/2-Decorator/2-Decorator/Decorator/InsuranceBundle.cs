namespace _2_Decorator.Decorator
{
    public class InsuranceBundle : BundleDecorator
    {
        private float insuranceCost;

        public InsuranceBundle(IInvoiceItem invoiceItem, float insuranceCost)
            : base(invoiceItem)
        {
            this.insuranceCost = insuranceCost;
        }

        public override string GetDetails()
        {
            return invoiceItem.GetDetails() + $" + insurance Cost ({insuranceCost})";
        }

        public override float GetPrice()
        {
            return invoiceItem.GetPrice() + insuranceCost;
        }
    }
}