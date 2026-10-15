namespace _3_FactoryMethod.Factory
{
    public static class LogisticsFactory
    {
        public static Logistics? Create(string type)
        {
            return type.ToLower() switch
            {
                "truck" => CreateRoad(),
                "ship" => CreateSea(),
                "plane" => CreateAir(),
                _ => null
            };
        }

        private static Logistics CreateRoad()
        {
            Console.Write("Enter Plate Number: ");
            string plate = Console.ReadLine();
            return new RoadLogistic(plate);
        }

        private static Logistics CreateSea()
        {
            Console.Write("Enter Port Code: ");
            int port = int.Parse(Console.ReadLine());
            return new SeaLogistic(port);
        }

        private static Logistics CreateAir()
        {
            Console.Write("Enter Flight Number: ");
            string flight = Console.ReadLine();
            return new AirLogistic(flight);
        }
    }
}
