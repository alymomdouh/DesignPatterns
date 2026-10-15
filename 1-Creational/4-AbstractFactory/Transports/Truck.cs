namespace _4_AbstractFactory.Transports
{
    public class Truck : ITransport
    {
        public void Deliver() => Console.WriteLine("Delivering by Truck 🚚");
    }
}
