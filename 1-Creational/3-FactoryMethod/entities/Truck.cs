namespace _3_FactoryMethod.entities
{
    public class Truck : ITransport
    {
        private readonly string _plateNumber;
        public Truck(string plateNumber) => _plateNumber = plateNumber;

        public void Deliver()
            => Console.WriteLine($"[🚚] Truck delivering using Plate: {_plateNumber}");
    }
}
