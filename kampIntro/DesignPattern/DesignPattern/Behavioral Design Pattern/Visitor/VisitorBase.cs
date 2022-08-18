namespace DesignPattern.Visitor
{
    public abstract class VisitorBase
    {
        public abstract void Visit(Worker worker);
        public abstract void Visit(Managers manager);

    }
}
