namespace _5_BuilderPattern
{
    public class HouseBuilder : IHouseBuilder
    {

        private int _walls;
        private int _doors;
        private bool _hasGarage;
        private bool _hasSwimmingPool;
        private bool _hasGarden;

        public IHouseBuilder BuildWalls(int walls)
        {
            if (walls <= 0)
                throw new ArgumentException("Number of walls must be greater than zero.");

            _walls = walls;
            return this;
        }
        public IHouseBuilder AddDoors(int doors)
        {
            if (doors <= 0)
                throw new ArgumentException("Number of doors must be greater than zero.");

            _doors = doors;
            return this;
        }

        public IHouseBuilder AddGarage()
        {
            _hasGarage = true;
            return this;
        }

        public IHouseBuilder AddGarden()
        {
            _hasGarden = true;
            return this;
        }

        public IHouseBuilder AddSwimmingPool()
        {
            if (!_hasGarden)
                throw new InvalidOperationException("Swimming pool can only be added if a garden is present.");

            _hasSwimmingPool = true;
            return this;
        }

        public House Build()
        {
            return new House(_walls, _doors, _hasGarage, _hasSwimmingPool, _hasGarden);
        }


    }
}