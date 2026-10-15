using _4_AbstractFactory.Documents;
using _4_AbstractFactory.Tracks;
using _4_AbstractFactory.Transports;

namespace _4_AbstractFactory.Factories
{
    public interface ILogisticFactory
    {
        ITransport CreateTransport();
        IReceit CreateReceit();
        ITracker CreateTracker();
    }
}