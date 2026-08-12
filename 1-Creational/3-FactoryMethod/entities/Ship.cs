namespace _3_FactoryMethod.entities
{
    public class Ship : ITransport
    {
        private readonly int _portCode;
        public Ship(int portCode) => _portCode = portCode;

        public void Deliver()
            => Console.WriteLine($"[🚢] Ship delivering via Port: {_portCode}");
    }
}
