namespace _3_FactoryMethod.entities
{
    public class Plane : ITransport
    {
        private readonly string _flightNumber;
        public Plane(string flightNumber) => _flightNumber = flightNumber;

        public void Deliver()
            => Console.WriteLine($"[✈️] Plane delivering via Flight: {_flightNumber}");
    }

}