namespace _5_BuilderPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var luxuryHouse = new HouseBuilder()
                        .BuildWalls(4)
                        .AddDoors(2)
                        .AddGarage()
                        .AddGarden()
                        .AddSwimmingPool()
                        .Build();



            var simpleHouse = new HouseBuilder()
                .BuildWalls(4)
                .AddDoors(2)
                .Build();


            var customHouse = new HouseBuilder()
                .BuildWalls(4)
                .AddDoors(2)
                .AddGarage()
                .AddGarden()
                .Build();

            Console.WriteLine("\n🏰 Luxury House:");
            Console.WriteLine(luxuryHouse);
            Console.WriteLine("\n🏠 Simple House:");
            Console.WriteLine(simpleHouse);
            Console.WriteLine("\n Custom House:");
            Console.WriteLine(customHouse);
            Console.ReadKey();
        }
    }
}
