namespace _4_State.State
{
    public interface IState
    {
        string Name { get; }
        void Edit(NewDocument doc);
        void Submit(NewDocument doc);
        void Publish(NewDocument doc);
        void Reject(NewDocument doc);
        void Expire(NewDocument doc);
    }
}
