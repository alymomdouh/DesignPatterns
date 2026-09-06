namespace _1_ChainOfResponsibility
{
    public class User
    {
        public int Id { get; set; }
        public bool IsAuthenticated { get; set; }
        public bool CanBuy { get; set; }
        public decimal Balance { get; set; }
        public string Email { get; set; }
    }
}