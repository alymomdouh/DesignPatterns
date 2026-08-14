namespace _5_BuilderPattern
{
    public class House
    {
        public int Walls { get; }
        public int Doors { get; }
        public bool HasGarage { get; }
        public bool HasSwimmingPool { get; }
        public bool HasGarden { get; }


        public House(int walls, int doors, bool hasGarage, bool hasSwimmingPool, bool hasGarden)
        {
            Walls = walls;
            Doors = doors;
            HasGarage = hasGarage;
            HasSwimmingPool = hasSwimmingPool;
            HasGarden = hasGarden;

        }

        public override string ToString()
        {
            return
                $"  Walls: {Walls}\n" +
                $"  Doors: {Doors}\n" +
                $"  Garage: {HasGarage}\n" +
                $"  Pool: {HasSwimmingPool}\n" +
                $"  Garden: {HasGarden}\n";

        }

    }
}
