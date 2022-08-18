namespace DesignPattern.Visitor
{
    public class Worker : EmployeeBase
    {
        public override void Accept(VisitorBase visitor)
        {
            visitor.Visit(this);
        }
    }
}
