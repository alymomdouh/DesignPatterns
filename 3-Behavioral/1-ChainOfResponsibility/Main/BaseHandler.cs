namespace _1_ChainOfResponsibility.Main
{
    public abstract class BaseHandler : IOrderHandler
    {
        private IOrderHandler _next;

        public void SetNext(IOrderHandler next)
        {
            _next = next;
        }

        public virtual void Handle(User user, Product product, int quantity)
        {
            if (_next != null)
                _next.Handle(user, product, quantity);
        }


    }
}
