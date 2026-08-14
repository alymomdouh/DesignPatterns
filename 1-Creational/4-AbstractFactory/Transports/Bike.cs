namespace _4_AbstractFactory.Transports
{
    public class Bike : ITransport
    {
        public void Deliver() => Console.WriteLine("Delivering by Bike 🛵");
    }
}
