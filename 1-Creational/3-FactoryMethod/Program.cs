using _3_FactoryMethod.Factory;

namespace _3_FactoryMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region old way
            //while (true)
            //{
            //    Console.Write("Enter logistics type (Road / Sea / Air) or 'exit' to quit: ");
            //    string input = Console.ReadLine();

            //    if (string.IsNullOrWhiteSpace(input))
            //    {
            //        Console.WriteLine("[❌] Input is empty. Please try again.\n");
            //        continue;
            //    }

            //    if (input.ToLower() == "exit")
            //    {
            //        Console.WriteLine("\nExiting system... Goodbye!");
            //        break;
            //    }

            //    Logistics logistics;

            //    if (input == "Road")
            //    {
            //        Console.Write("Enter Plate Number: ");
            //        string plate = Console.ReadLine();
            //        logistics = new RoadLogistic(plate);
            //    }
            //    else if (input == "Sea")
            //    {
            //        Console.Write("Enter Port Code: ");
            //        int port = int.Parse(Console.ReadLine());
            //        logistics = new SeaLogistic(port);
            //    }
            //    else if (input == "Air")
            //    {
            //        Console.Write("Enter Flight Number: ");
            //        string flight = Console.ReadLine();
            //        logistics = new AirLogistic(flight);
            //    }
            //    else
            //    {
            //        Console.WriteLine("[❌] Unknown logistics type. Try 'Road', 'Sea', or 'Air'.\n");
            //        continue;
            //    }

            //    logistics.PlanDelivery();
            //    Console.WriteLine("----------------------------------------\n");
            //}

            #endregion


            while (true)
            {
                Console.Write("Enter transport type (Truck / Ship / Plane) or 'exit' to quit: ");
                string input = Console.ReadLine()?.Trim();

                if (input == "exit")
                {
                    Console.WriteLine("\nExiting system... Goodbye!");
                    break;
                }

                var logistics = LogisticsFactory.Create(input);

                if (logistics == null)
                {
                    Console.WriteLine("[❌] Invalid transport type. Try again.\n");
                    continue;
                }

                logistics.PlanDelivery();
                Console.WriteLine("----------------------------------------\n");
            }
        }
    }
}
