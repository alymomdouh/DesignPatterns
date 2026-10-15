namespace _4_State.State
{
    public class ExpiredState : IState
    {
        public string Name => "Expired";

        public void Edit(NewDocument doc)
        {
            Console.WriteLine("❌ You cannot edit an expired document. Reset to Draft first.");
        }

        public void Submit(NewDocument doc)
        {
            Console.WriteLine("❌ Cannot submit an expired document. Reset to Draft first.");
        }

        public void Publish(NewDocument doc)
        {
            Console.WriteLine("❌ Cannot publish an expired document.");
        }

        public void Reject(NewDocument doc)
        {
            Console.WriteLine("❌ Cannot reject an expired document.");
        }

        public void Expire(NewDocument doc)
        {
            Console.WriteLine("ℹ️ Already expired.");
        }
    }
}