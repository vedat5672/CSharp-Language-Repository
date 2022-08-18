namespace DesignPattern.State
{
    public class ModifiedState : IState
    {
        public void DoAction(Context context)
        {
            Console.WriteLine("State Modified");
            context.SetState(this);
        }
        public override string ToString()
        {
            return "Modified";
        }
    }  
}
