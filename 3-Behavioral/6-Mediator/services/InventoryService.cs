namespace _6_Mediator.services
{
    public class InventoryService
    {
        public void RemoveStock(int productId, int quantity)
        {
            Console.WriteLine(
                $"Removed {quantity} item(s) of Product #{productId}");
        }
    }
}
