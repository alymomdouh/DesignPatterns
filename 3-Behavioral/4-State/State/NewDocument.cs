namespace _4_State.State
{
    public class NewDocument
    {
        private IState _state;

        public string StateName => _state.Name;

        public NewDocument()
        {
            _state = new DraftState();
        }

        public void ChangeState(IState newState)
        {
            _state = newState;
            Console.WriteLine($"[State] -> {newState}");
        }

        public void ResetToDraft()
        {
            ChangeState(new DraftState());
            Console.WriteLine("Reset To Draft.");
        }

        public void Edit() => _state.Edit(this);
        public void Submit() => _state.Submit(this);

        public void Publish() => _state.Publish(this);

        public void Reject() => _state.Reject(this);

        public void Expire() => _state.Expire(this);


    }
}