using _4_AbstractFactory.Documents;
using _4_AbstractFactory.Tracks;
using _4_AbstractFactory.Transports;

namespace _4_AbstractFactory.Factories
{
    public class MotoFactory : ILogisticFactory
    {
        public ITransport CreateTransport() => new Motor();

        public IReceit CreateReceit() => new PaperReceit();

        public ITracker CreateTracker() => new RoadCameraTracker();
    }
}
