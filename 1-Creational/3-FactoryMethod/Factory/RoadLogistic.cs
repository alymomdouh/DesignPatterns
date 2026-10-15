using _3_FactoryMethod.entities;

namespace _3_FactoryMethod.Factory
{
    public class RoadLogistic : Logistics
    {
        private readonly string _planeNumber;

        public RoadLogistic(string plateNumber)
        {
            _planeNumber = plateNumber;
        }
        public override ITransport CreateTransport()
        {
            return new Truck(_planeNumber);
        }
    }
}
