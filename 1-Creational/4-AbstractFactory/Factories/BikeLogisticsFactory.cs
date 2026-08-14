using _4_AbstractFactory.Documents;
using _4_AbstractFactory.Tracks;
using _4_AbstractFactory.Transports;

namespace _4_AbstractFactory.Factories
{
    public class BikeLogisticsFactory : ILogisticFactory
    {
        public ITransport CreateTransport() => new Bike();
        public IReceit CreateReceit() => new DigitalReceit();
        public ITracker CreateTracker() => new GPSBikeTracker();
    }

}
