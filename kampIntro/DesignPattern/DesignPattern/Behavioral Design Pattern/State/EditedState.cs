namespace DesignPattern.State
{
    public class EditedState : IState
    {
        public void DoAction(Context context)
        {
            Console.WriteLine("State Edited");
            context.SetState(this);
        }
        public override string ToString()
        {
            return "Edited";
        }
    }
}
