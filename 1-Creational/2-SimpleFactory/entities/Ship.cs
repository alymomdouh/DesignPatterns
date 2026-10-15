namespace _2_SimpleFactory.entities
{
    public class Ship : ITransport
    {
        public void Deliver() => Console.WriteLine("[🚢] Delivery Status: Delivered by Ship");
    }
}
