namespace DesignPattern.State
{
    public class Context
    {
        IState _state;
        public void SetState(IState state)
        {
            _state = state;
        }
        public IState GetState()
            { return _state; }
    }
}
