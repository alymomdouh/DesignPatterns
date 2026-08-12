using _3_FactoryMethod.entities;

namespace _3_FactoryMethod.Factory
{
    internal class SeaLogistic : Logistics
    {
        private readonly int _portCode;

        public SeaLogistic(int portCode)
        {
            _portCode = portCode;
        }
        public override ITransport CreateTransport()
        {
            return new Ship(_portCode);
        }
    }
}