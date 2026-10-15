namespace _2_SimpleFactory.entities
{
    internal class AirPlane : ITransport
    {
        public void Deliver() => Console.WriteLine("✈️ Delivery Status: Delivered by AirPlane");

    }
}
