using _1_ChainOfResponsibility.Handlers;

namespace _1_ChainOfResponsibility.Main
{
    public class OrderHandlerChainBuiler
    {
        public IOrderHandler Build()
        {
            var auth = new AuthinticatioHandler();
            var permission = new AuthorizationHandler();
            var stock = new StockHandler();
            var balance = new BalanceHandler();
            var payment = new PaymentHandler();
            var order = new OrderHandler();
            var notification = new NotificationHandler();


            auth.SetNext(permission);
            permission.SetNext(stock);
            stock.SetNext(balance);
            balance.SetNext(payment);
            payment.SetNext(order);
            order.SetNext(notification);

            return auth;

        }
    }
}
