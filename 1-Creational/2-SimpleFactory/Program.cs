using _2_SimpleFactory.entities;

namespace _2_SimpleFactory
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Logistics Delivery System ===\n");
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            while (true)
            {
                #region start
                Console.Write("Enter transport type (Truck / Ship / Airplane) or 'exit' to quit: ");
                string input = Console.ReadLine();

                if (input.ToLower() == "exit")
                {
                    Console.WriteLine("\nExiting system... Goodbye!");
                    break;
                }
                Console.OutputEncoding = System.Text.Encoding.UTF8;
                #endregion

                 
                #region old way or problem
                /*
                ITransport transport;
                if (input == "Truck")
                {
                    Console.WriteLine("[✔] Transport Created: Truck");
                    transport = new Truck();
                }
                else if (input == "Ship")
                {
                    Console.WriteLine("[✔] Transport Created: Ship");
                    transport = new Ship();
                }
                else if (input == "Airplane")
                {
                    Console.WriteLine("[✔] Transport Created: Airplane");
                    transport = new AirPlane();
                }
                else
                {
                    Console.WriteLine("[❌] Unknown transport type. Please try again.");
                    Console.WriteLine("----------------------------------------\n");
                    continue;
                }
                */
                #endregion


                ITransport transport2= TransportFactory.CreateTransportFactory(input);
                Console.WriteLine($"[✔] Transport Created: {input}");
                transport2.Deliver();
                Console.WriteLine("----------------------------------------\n");

            }

            Console.ReadKey();
        }
    }
}
