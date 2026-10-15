using _4_AbstractFactory.Factories;

namespace _4_AbstractFactory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("🚚 Available Delivery Options Based on Package Weight:");
            Console.WriteLine("  • Up to 3 kg     → Bike + Digital Receipt + GPS Tracker");
            Console.WriteLine("  • 4 to 10 kg     → Motorbike + Paper Receipt + Road Camera Tracker");
            Console.WriteLine("  • More than 10 kg → Truck + Official Receipt + Satellite Tracker\n");


            while (true)
            {
                Console.Write("📦 Enter package weight (or type 'exit'): ");
                string input = Console.ReadLine();

                if (input?.ToLower() == "exit")
                    break;

                if (!double.TryParse(input, out double weight))
                {
                    Console.WriteLine("[❌] Invalid weight. Please enter a number.\n");
                    continue;
                }

                ILogisticFactory factory = weight switch
                {
                    <= 3 => new BikeLogisticsFactory(),
                    <= 10 => new MotoFactory(),
                    _ => new TruckLogisticFactory()
                };

                Console.WriteLine("\n🚀 Delivery in progress...");
                var transport = factory.CreateTransport();
                var document = factory.CreateReceit();
                var tracker = factory.CreateTracker();

                transport.Deliver();
                document.Print();
                tracker.Track();

                Console.WriteLine("\n-----------------------------------------\n");
            }
        }
    }
}
