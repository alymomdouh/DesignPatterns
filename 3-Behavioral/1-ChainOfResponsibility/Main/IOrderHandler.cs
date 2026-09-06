namespace _1_ChainOfResponsibility.Main
{
    public interface IOrderHandler
    {
        void SetNext(IOrderHandler next);
        void Handle(User user, Product product, int quantity);
    }
}
