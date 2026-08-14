using _4_AbstractFactory.Documents;
using _4_AbstractFactory.Tracks;
using _4_AbstractFactory.Transports;

namespace _4_AbstractFactory.Factories
{
    public class TruckLogisticFactory : ILogisticFactory
    {
        public ITransport CreateTransport() => new Truck();

        public IReceit CreateReceit() => new OfficialReceit();

        public ITracker CreateTracker() => new SatelliteTracker();
    }
}