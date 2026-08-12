using _3_FactoryMethod.entities;

namespace _3_FactoryMethod.Factory
{
    internal class AirLogistic : Logistics
    {
        private readonly string _flightNumber;

        public AirLogistic(string flightNumber)
        {
            _flightNumber = flightNumber;
        }
        public override ITransport CreateTransport()
        {
            return new Plane(_flightNumber);
        }
    }
}
