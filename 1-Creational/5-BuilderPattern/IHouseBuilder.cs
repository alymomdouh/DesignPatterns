namespace _5_BuilderPattern
{
    public interface IHouseBuilder
    {
        IHouseBuilder BuildWalls(int walls);
        IHouseBuilder AddDoors(int doors);
        IHouseBuilder AddGarage();
        IHouseBuilder AddSwimmingPool();
        IHouseBuilder AddGarden();
        House Build();
    }
}
