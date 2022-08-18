namespace DesignPattern.State
{
    public class DeletedState : IState
    {
        public void DoAction(Context context)
        {
            Console.WriteLine("State Deleted");
            context.SetState(this);
        }
        public override string ToString()
        {
            return "Deleted";
        }
    }   
}
