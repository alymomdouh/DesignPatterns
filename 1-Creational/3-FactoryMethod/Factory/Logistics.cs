using _3_FactoryMethod.entities;

namespace _3_FactoryMethod.Factory
{
    public abstract class Logistics
    {
        public void PlanDelivery()
        {
            ITransport transport = CreateTransport();
            Console.WriteLine("Transport Created using Factory Method");
            transport.Deliver();
        }

        public abstract ITransport CreateTransport();
    }
}